using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMirror.Dataaccess.Entries.Traffic
{
    public class Elements
    {
        public Distance[] distances { get; set; }
        public Duration[] durations { get; set; }
        public string status { get; set; }
    }
}
