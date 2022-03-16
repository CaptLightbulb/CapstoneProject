using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchList.Logic.Database
{
    public class DataRepository<K> where K : class //Generic class to set up some necessary framework used by the specific data repository classes
    {
        WatchListDbContext Context;
        public DataRepository(WatchListDbContext context) //Constructor to initialize database context
        {
            Context = context;
        }



        public IEnumerable<K> GetAll() //method to return a complete list of a class from the database
        {
            return Context.Set<K>();
        }



        public void Add(K entity) //method to add an object to its database table
        {
            Context.Set<K>().Add(entity);
        }



        public void Remove(K entity)//method to remove an object from its database
        {
            Context.Set<K>().Remove(entity);
        }
    }
}
