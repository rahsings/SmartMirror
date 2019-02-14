using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMirror.ConsoleApp.Models
{
    class TimeDetails
    {
        public string Destination { get; set; }

        public double Distance { get; set; }

        public string DistanceUOM { get; set; }

        public int Minutes { get; set; }

        public DateTime TimeOfArrival
        {
            get
            {
                return DateTime.Now.AddMinutes(Minutes);
            }
        }
    }
}
