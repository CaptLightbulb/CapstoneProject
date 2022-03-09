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

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            Context = new WatchListDbContext();
            UOW = new DataUnitOfWork(Context);
            ListModel = new ListViewModel { UOW = UOW};
        }

        public IActionResult Index()
        {
            return View("ViewAll", ListModel);
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
            }

            return View();
        }

        public IActionResult DeleteShow(int ShowId)
        {

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
    }
}

/*

*/
