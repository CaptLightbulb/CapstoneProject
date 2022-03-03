﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WatchList.Logic.Models
{
    class Season
    {
        public Show Show { get; set; } //Set up properties
        [ForeignKey("Show")]
        public int ShowId { get; set; }
        public int Score { get; set; }
        public int SeasonId { get; set; }
        public string Status { get; set; }
        private int statusNum;
        public int StatusNum //Propertie to change the value of string Status to match the number given
        {
            get
            {
                return statusNum;
            }
            set
            {
                switch (value)
                {
                    case 0:
                        Status = "Plan To Watch";
                        break;
                    case 1:
                        Status = "Watching";
                        break;
                    case 2:
                        Status = "Finished";
                        break;
                }
                statusNum = value;
            }
        }
    }
}