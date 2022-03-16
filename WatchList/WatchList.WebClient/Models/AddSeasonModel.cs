using WatchList.Logic.Database;

namespace WatchList.WebClient.Models
{
    public class AddSeasonModel //model to hold necessary information for the addiction of user-defined seasons to the database
    {
        public DataUnitOfWork UOW { get; set; }
        public int Order { get; set; }
        public int ShowId { get; set; }
        public int Status { get; set; }
    }
}
