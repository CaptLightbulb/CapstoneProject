using WatchList.Logic.Models;
using WatchList.Logic.Database;

namespace WatchList.WebClient.Models
{
    public class ListViewModel
    {
        public DataUnitOfWork UOW { get; set; }
        public string NameKey { get; set; } = "";
        public int StatusKey { get; set; } = -1;
        public int ShowId { get; set; }
    }
}
