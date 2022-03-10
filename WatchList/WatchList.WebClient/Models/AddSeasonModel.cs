using WatchList.Logic.Database;

namespace WatchList.WebClient.Models
{
    public class AddSeasonModel
    {
        public DataUnitOfWork UOW { get; set; }
        public int Order { get; set; }
        public int ShowId { get; set; }
        public int Status { get; set; }
    }
}
