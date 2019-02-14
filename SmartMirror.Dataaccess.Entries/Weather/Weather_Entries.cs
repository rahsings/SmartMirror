using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMirror.Dataaccess.Entries.Weather
{
    public class Weather_Entries
    {
        public Cordinates coord { get; set; }
        public Weather_Report[] weather { get; set; }
        public string _base { get; set; }
        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
        public Cloud clouds { get; set; }
        public int tt { get; set; }
        public Sys sys { get; set; }
        public int id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }
    }
}
