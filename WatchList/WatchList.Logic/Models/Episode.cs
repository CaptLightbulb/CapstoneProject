using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WatchList.Logic.Models
{
    class Episode
    {
        public Show Show { get; set; } //Set up properties
        [ForeignKey("Show")]
        public int ShowId { get; set; }
        public Season Season { get; set; }
        [ForeignKey("Season")]
        public int SeasonId { get; set; }
        public int Score { get; set; }
        public int EpisodeId { get; set; }
    }
}
