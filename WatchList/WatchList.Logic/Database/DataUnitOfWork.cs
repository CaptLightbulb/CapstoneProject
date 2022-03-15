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

        public void CascadeStatus()
        {
            List<Show> showList = Shows.GetAll().ToList();

            foreach(var season in Context.Seasons)
            {
                if (showList.FirstOrDefault(sh => sh.ShowId == season.ShowId).StatusNum == 2) season.StatusNum = 2;
                if(showList.FirstOrDefault(sh => sh.ShowId == season.ShowId).StatusNum == 1) season.StatusNum = 1;
            }

            foreach(var season in Context.Seasons)
            {
                if (season.StatusNum == 2) season.EpisodesWatched = season.EpisodeAmt;
                if (season.StatusNum == 1) season.EpisodesWatched = 0;
            }
        }

        private void CheckSeasonStatus()
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

        private void CheckShowStatus()
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
