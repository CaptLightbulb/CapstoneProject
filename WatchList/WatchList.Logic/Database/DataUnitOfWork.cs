using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchList.Logic.Models;

namespace WatchList.Logic.Database
{
    public class DataUnitOfWork
    {
        public WatchListDbContext Context { get; set; }
        public DataShowRepository Shows;
        public DataSeasonRepository Seasons;

        public DataUnitOfWork(WatchListDbContext context)
        {
            Context = context;
            Shows = new DataShowRepository(context);
            Seasons = new DataSeasonRepository(context);
        }

        public int Complete()
        {
            Context.SaveChanges();
            CheckSeasonStatus();
            CheckShowStatus();
            return Context.SaveChanges();
        }

        public void CheckSeasonStatus()
        {
            foreach(var season in Context.Seasons)
            {
                if (season.EpisodesWatched == 0)
                {
                    season.StatusNum = 1;
                }
                else
               if (season.EpisodesWatched >= season.EpisodeAmt)
                {
                    season.EpisodesWatched = season.EpisodeAmt;
                    season.StatusNum = 2;
                }
                else
                {
                    season.StatusNum = 0;
                }
            }
        }

        public void CheckShowStatus()
        {
            List<Season> seasonList = Seasons.GetAll().ToList();

            foreach(var show in Context.Shows)
            {
                bool finished = true;
                foreach(var season in seasonList.Where(se => se.ShowId == show.ShowId))
                {
                    if (season.StatusNum != 2) finished = false;
                }
                bool planned = true;
                foreach(var season in seasonList.Where(se => se.ShowId == show.ShowId))
                {
                    if (season.StatusNum != 1) planned = false;
                }

                if (finished) show.StatusNum = 2; else if (planned) show.StatusNum = 1; else show.StatusNum = 0; 
            }
        }
    }
}
