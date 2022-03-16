using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WatchList.WebClient.Models;
using WatchList.Logic.Models;
using WatchList.Logic.Database;

namespace WatchList.WebClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public WatchListDbContext Context;
        public DataUnitOfWork UOW;
        public ListViewModel ListModel;
        public AddSeasonModel seasonModel;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            Context = new WatchListDbContext();
            UOW = new DataUnitOfWork(Context);
            ListModel = new ListViewModel { UOW = UOW};
            seasonModel = new AddSeasonModel { UOW = UOW};
        }



        public IActionResult Index() //method to display the main page with the list of shows
        {
            return View("ViewShows", ListModel);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        //method to add a new show to the database and/or redirect to the 'AddShow' Page
        //redirects to the 'CreateSeason' page to initialize information about the seasons in the added show
        public IActionResult AddShow(string Name, int SeasonAmt, string StatusType)
        {
            if (Name != null)
            {
                var addShow = new Show { Name = Name, StatusNum = int.Parse(StatusType)};

                UOW.Shows.Add(addShow);
                UOW.Complete();

                int showId = UOW.Shows.Find(Name).FirstOrDefault().ShowId;

                for (int i = 0; i < SeasonAmt; i++)
                {
                    var addSeason = new Season();
                    addSeason.ShowId = showId;
                    addSeason.Order = i + 1;
                    UOW.Seasons.Add(addSeason);
                }
                UOW.Complete();
                seasonModel.ShowId = showId;
                return CreateSeason();
            }

            return View();
        }



        //method to remove a show from the database
        //will also delete every season associated with the deleted show
        public IActionResult DeleteShow(int ShowId) 
        {
            List<Season> seasonList = UOW.Seasons.GetSeasonsInOrder(ShowId).ToList();
            foreach (var season in seasonList)
            {
                DeleteSeason(season.SeasonId, false);
            }
            UOW.Shows.Remove(UOW.Shows.Find(ShowId));
            UOW.Complete();

            return Index();
        }



        public IActionResult ChangeShowInfo(int ShowId, string ScoreNum, string StatusType) //method to alter certain user-defined properties of a show
        {
            UOW.Shows.Find(ShowId).Score = int.Parse(ScoreNum);
            UOW.Shows.Find(ShowId).StatusNum = int.Parse(StatusType);

            UOW.CascadeStatus();
            UOW.Complete();

            return Index();
        }



        public IActionResult SearchShow(string statusKey, string nameKey) //method to narrow the list of shows based on uer-input criteria
        {
            if (nameKey == null) nameKey = "";

            ListModel.NameKey = nameKey;
            ListModel.StatusKey = int.Parse(statusKey);

            return Index();
        }



        public IActionResult ResetSearch() //method to reset the user-input serach parameters and view the entire list of shows
        {
            ListModel.NameKey = "";
            ListModel.StatusKey = -1;

            return Index();
        }


        //method to initialize key information about a season
        //presented to the user immediately after adding a new show to the database
        public IActionResult CreateSeason(int EpisodeWatch = 0, int EpisodeNum = 0, int SeasonId = 0) 
        {
            if(EpisodeNum != 0)
            {
                var season = UOW.Seasons.FindById(SeasonId);

                season.EpisodeAmt = EpisodeNum;
                season.EpisodesWatched = EpisodeWatch;

                UOW.CascadeStatus();
                UOW.Complete();

                seasonModel.ShowId = season.ShowId;
            }

            return View("CreateSeason", seasonModel);
        }



        public IActionResult ViewSeasons(int ShowId = 0) //method to bring up the list of seasons for a given show
        {
            ListModel.ShowId = ShowId;
            return View("ViewSeasons",ListModel);
        }



        public IActionResult ChangeSeason(int EpisodeWatch, int SeasonId, int ScoreNum) //method to change given user-defined information about a season
        {
            var season = UOW.Seasons.FindById(SeasonId);
            season.EpisodesWatched = EpisodeWatch;
            season.Score = ScoreNum;
            UOW.Complete();

            return ViewSeasons(season.ShowId);
        }



        //method to remove a season from the database
        //will automatically adjust the order of other seasons where necessary so as to compensate for this removal
        public IActionResult DeleteSeason(int SeasonId, bool callFromView = true) 
        {
            var season = UOW.Seasons.FindById(SeasonId);
            foreach (var upperSeason in UOW.Seasons.GetSeasonsInOrder(season.ShowId).Where(s => s.Order > season.Order))
            {
                upperSeason.Order--;
            }

            UOW.Seasons.Remove(season);
            UOW.Complete();

            if (callFromView)
            {
                return ViewSeasons(season.ShowId);
            }
            else
            {
                return null;
            }

        }



        //method to add a season from the 'ViewSeason' pages any time after a show is already created
        //unlike 'CreateSeason' method which uses its own page and is only used immediately after a show is created
        //if an 'Order' value is specified that already exists, all seasons that have that order value or higher will be increased by one to accomodate
        public IActionResult AddSeason(int episodesWatched, int episodeAmt, int showId, int order = 0)
        {
            var newSeason = new Season { EpisodesWatched = episodesWatched, EpisodeAmt = episodeAmt, ShowId = showId };
            
            if(order > 0 && order <= UOW.Seasons.GetSeasonsInOrder(showId).Count())
            {
                foreach(var season in UOW.Seasons.GetSeasonsInOrder(showId))
                {
                    if(season.Order >= order) season.Order++;
                }
                newSeason.Order = order;
            }
            else
            {
                newSeason.Order = UOW.Seasons.GetSeasonsInOrder(showId).Count() + 1;
            }

            UOW.Seasons.Add(newSeason);
            UOW.Complete();

            return ViewSeasons(showId);
        }
    }
}