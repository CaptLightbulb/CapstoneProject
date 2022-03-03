using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchList.Logic.Database
{
    class DataRepository<K> where K : class
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

        public void AddRange(IEnumerable<K> entities) //method to add multiple objects to their databse table
        {
            Context.Set<K>().AddRange(entities);
        }

        public void Remove(K entity)//method to remove an object from its database
        {
            Context.Set<K>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<K> entities)//method to remove multiple objects from their database table
        {
            foreach(var entity in entities)
            {
                Context.Set<K>().Remove(entity);
            }
        }

        public IEnumerable<K> Find(Func<K, bool> predicate)//method to find a list of objects that match a given predicate
        {
            var returnList = new List<K>();

            foreach(var entity in Context.Set<K>())
            {
                if (predicate(entity))
                {
                    returnList.Add(entity);
                }
            }

            if (returnList.Count > 0)
            {
                return returnList;
            }
            return null;
        }
    }
}
