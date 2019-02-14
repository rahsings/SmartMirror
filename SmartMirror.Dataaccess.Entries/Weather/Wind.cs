using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMirror.Dataaccess.Entries.Weather
{
    public class Wind
    {
        public float speed { get; set; }
        public int deg { get; set; }
        public float gust { get; set; }
    }
}
