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

        public IActionResult Index()
        {
            return View("ViewShows", ListModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AddShow(string Name, int SeasonAmt, string StatusType) //method to add a new show to the database and/or redirect to the 'AddShow' Page
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

        public IActionResult ChangeInfo(int ShowId, string ScoreNum, string StatusType)
        {
            UOW.Shows.Find(ShowId).Score = int.Parse(ScoreNum);
            UOW.Shows.Find(ShowId).StatusNum = int.Parse(StatusType);
            UOW.Complete();

            return Index();
        }

        public IActionResult SearchName(string SearchKey)
        {
            ListModel.SearchKey = SearchKey;

            return Index();
        }

        public IActionResult ResetSearch()
        {
            ListModel.SearchKey = "";

            return Index();
        }

        public IActionResult CreateSeason(int EpisodeWatch = 0, int EpisodeNum = 0, int SeasonId = 0)
        {
            if(EpisodeNum != 0)
            {
                var season = UOW.Seasons.FindById(SeasonId);

                season.EpisodeAmt = EpisodeNum;
                season.EpisodesWatched = EpisodeWatch;

                UOW.Complete();

                seasonModel.ShowId = season.ShowId;
            }

            return View("CreateSeason", seasonModel);
        }

        public IActionResult ViewSeasons(int ShowId = 0)
        {
            ListModel.ShowId = ShowId;
            return View("ViewSeasons",ListModel);
        }

        public IActionResult ChangeSeason(int EpisodeWatch, int SeasonId, int ScoreNum)
        {
            var season = UOW.Seasons.FindById(SeasonId);
            season.EpisodesWatched = EpisodeWatch;
            season.Score = ScoreNum;
            UOW.Complete();

            return ViewSeasons(season.ShowId);
        }

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
    }
}

/*

*/
