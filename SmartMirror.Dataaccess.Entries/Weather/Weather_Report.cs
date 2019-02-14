using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMirror.Dataaccess.Entries.Weather
{
    public class Weather_Report
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }
}
