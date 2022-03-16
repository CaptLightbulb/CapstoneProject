using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchList.Logic.Models;

namespace WatchList.Logic.Database
{
    public class DataUnitOfWork //Class gives the ability to use the defined repositories to interface with the database
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



        public int Complete() //Method to save any changes to the databased and make some necessary adjustments along the way
        {
            Context.SaveChanges();
            CheckSeasonStatus();
            CheckShowStatus();
            return Context.SaveChanges();
        }



        //Method to be called whenever the user manually changes the status of a Show to either 'Finished' or 'Plan To Watch'
        //Will impose the chosen status on any seasons and subsequent episodes that are associated with the show
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



        //Method to adjust the status of a season based on a change in Episodes Watched
        //Will be called everytime the changes are comitted to the database
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



        //Method to adjust the status of a Show based on a change in the status of its Seasons
        //Will be called everytime the changes are comitted to the database
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
