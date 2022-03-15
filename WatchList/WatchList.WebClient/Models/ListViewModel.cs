using WatchList.Logic.Models;
using WatchList.Logic.Database;

namespace WatchList.WebClient.Models
{
    public class ListViewModel
    {
        public DataUnitOfWork UOW { get; set; }
        public string SearchKey { get; set; } = "";
        public int ShowId { get; set; }
    }
}
