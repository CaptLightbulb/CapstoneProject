using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchList.Logic.Models;

namespace WatchList.Logic.Database
{
    public class DataSeasonRepository : DataRepository<Season> //Repository class used to access and alter the Seasons in the database with custom defined methods
    {
        WatchListDbContext Context;

        public DataSeasonRepository(WatchListDbContext context) : base(context)
        {
            Context = context;
        }

        public IEnumerable<Season> GetSeasonsInOrder(int showId) //sorts seasons of a given show by their order
        {
            var sortedList =
                from season in Context.Seasons
                where season.ShowId == showId
                orderby season.Order
                select season;

            return sortedList;
        }

        public Season FindById(int seasonId) //method to retrieve a Season from the database given its ID
        {
            return Context.Seasons.FirstOrDefault(s => s.SeasonId == seasonId);
        }
    }
}
