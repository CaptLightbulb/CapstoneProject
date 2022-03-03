using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchList.Logic.Models;

namespace WatchList.Logic.Database
{
    class DataShowRepository : DataRepository<Show>
    {
        WatchListDbContext Context;

        public DataShowRepository(WatchListDbContext context) : base(context)
        {
            Context = context;
        }

        public Show Find(int id)
        {
            return Context.Shows.FirstOrDefault(show => show.ShowId == id);
        }

        public IEnumerable<Show> Find(string name)
        {
            var returnList = new List<Show>();

            foreach(var show in Context.Shows)
            {
                if (show.Name.ToUpper().Contains(name.ToUpper())) returnList.Add(show);
            }

            if (returnList.Count > 0)
            {
                return returnList;
            }
            return null;
        }

        public IEnumerable<Show> GetShowsByName()
        {
            var sortedList =
                from show in Context.Shows
                orderby show.Name
                select show;

            return sortedList;
        }
    }
}
