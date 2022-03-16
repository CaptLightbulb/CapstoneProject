using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchList.Logic.Models
{
    public class Show
    {
        public string Name { get; set; } //Set up properties
        public int Score { get; set; }
        public int ShowId { get; set; }
        public string Status { get; set; }
        private int statusNum;
        public int StatusNum 
        {
            get
            {
                return statusNum;
            }
            set
            {
                switch (value) //property setter will adjust the value of the 'Status' string for display purposes any time the int 'StatusNum' is altered
                {
                    case 1: Status = "Plan To Watch";
                        break;
                    case 0: Status = "Watching";
                        break;
                    case 2: Status = "Finished";
                        break;
                }
                statusNum = value;
            }
        }
    }
}
