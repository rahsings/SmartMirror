using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMirror.Dataaccess.Entries.Traffic
{
    public class Traffic_Entity
    {
        public string[] Destination_addresses { get; set; }
        public string[] Origin_addresses { get; set; }
        public Row[] Rows { get; set; }
        public string status { get; set; }
    }
}
