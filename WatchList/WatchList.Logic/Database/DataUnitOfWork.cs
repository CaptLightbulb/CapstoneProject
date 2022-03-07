using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchList.Logic.Database
{
    public class DataUnitOfWork
    {
        public WatchListDbContext Context { get; set; }
        public DataShowRepository Shows;
        public DataSeasonRepository Seasons;
        public DataEpisodeRepository Episodes;

        public DataUnitOfWork(WatchListDbContext context)
        {
            Context = context;
            Shows = new DataShowRepository(context);
            Seasons = new DataSeasonRepository(context);
            Episodes = new DataEpisodeRepository(context);
        }

        public int Complete()
        {
            return Context.SaveChanges();
        }
    }
}
