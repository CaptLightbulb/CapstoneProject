using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchList.Logic.Models;

namespace WatchList.Logic.Database
{
    class DataEpisodeRepository : DataRepository<Episode>
    {
        WatchListDbContext Context;

        public DataEpisodeRepository(WatchListDbContext context) : base(context)
        {
            Context = context;
        }

        public IEnumerable<Episode> GetEpisodesInOrder(int seasonId)
        {
            var sortedList =
                from episode in Context.Episodes
                where episode.SeasonId == seasonId
                orderby episode.Order
                select episode;

            return sortedList;
        }

        public void Add(int seasonId)
        {
            var addEpisode = new Episode {SeasonId = seasonId, ShowId = Context.Seasons.FirstOrDefault(season => season.SeasonId == seasonId).ShowId };
            addEpisode.Order = GetEpisodesInOrder(seasonId).Count() + 1;
            Context.Episodes.Add(addEpisode);
        }
    }
}
