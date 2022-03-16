using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchList.Logic.Models;

namespace WatchList.Logic.Database
{
    public class DataShowRepository : DataRepository<Show> //Repository class used to access and alter the Shows in the database with custom defined methods
    {
        WatchListDbContext Context;

        public DataShowRepository(WatchListDbContext context) : base(context)
        {
            Context = context;
        }

        public Show Find(int id) //method to retrieve a show given its ID
        {
            return Context.Shows.FirstOrDefault(show => show.ShowId == id);
        }



        public IEnumerable<Show> Find(string name) //method to find a show given its name
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



        //method to retrieve a list of shows sorted by their status
        //optional parameters to narrow the list of result to particular search criteria
        public IEnumerable<Show> GetShowsByStatus(string nameKey = "", int statusKey = -1) 
        {
            IQueryable<Show> sortedList;

            if(statusKey > -1)
            {
                sortedList =
                 from show in Context.Shows
                 where show.Name.ToUpper().Contains(nameKey.ToUpper()) && show.StatusNum == statusKey
                 orderby show.StatusNum, show.Name
                 select show;
            }
            else
            {
                sortedList =
                from show in Context.Shows
                where show.Name.ToUpper().Contains(nameKey.ToUpper())
                orderby show.StatusNum, show.Name
                select show;
            }

            return sortedList;
        }
    }
}
