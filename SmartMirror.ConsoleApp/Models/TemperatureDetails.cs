using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMirror.ConsoleApp.Models
{
    class TemperatureDetails
    {
        public string Location { get; set; }

        public double Temperature { get; set; }

        public string TemperatureUOM { get; set; }

        public string WeatherType { get; set; }

        public string Sunrise { get; set; }

        public string Sunset { get; set; }
    }
}
