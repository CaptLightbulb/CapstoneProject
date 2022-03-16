using WatchList.Logic.Models;
using WatchList.Logic.Database;

namespace WatchList.WebClient.Models
{
    public class ListViewModel //model to hold necessary information for displaying lists of shows and seasons
    {
        public DataUnitOfWork UOW { get; set; }
        public string NameKey { get; set; } = "";
        public int StatusKey { get; set; } = -1;
        public int ShowId { get; set; }
    }
}
