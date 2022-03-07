using Microsoft.AspNetCore.Mvc;
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


            return View(ListModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AddShow([Bind("Name, SeasonAmt, Status")] AddShowModel modelShow) //method to add a new show to the database and/or redirect to the 'AddShow' Page
        {
            if (modelShow.Name != null)
            {
                var addShow = new Show { Name = modelShow.Name, StatusNum = modelShow.Status};

                UOW.Shows.Add(addShow);
                UOW.Complete();
            }
            return View();
        }
    }
}
