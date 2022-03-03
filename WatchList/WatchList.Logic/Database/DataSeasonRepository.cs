using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchList.Logic.Models;

namespace WatchList.Logic.Database
{
    class DataSeasonRepository : DataRepository<Season>
    {
        WatchListDbContext Context;

        public DataSeasonRepository(WatchListDbContext context) : base(context)
        {
            Context = context;
        }

        public IEnumerable<Season> GetSeasonsInOrder(int showId)
        {
            var sortedList =
                from season in Context.Seasons
                where season.ShowId == showId
                orderby season.Order
                select season;

            return sortedList;
        }

        public void Add(int showId)
        {
            var addSeason = new Season { ShowId = showId };
            addSeason.Order = GetSeasonsInOrder(showId).Count() + 1;
            Context.Seasons.Add(addSeason);
        }
    }
}
