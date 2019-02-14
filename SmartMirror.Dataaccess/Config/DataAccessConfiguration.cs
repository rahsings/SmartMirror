using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMirror.Dataaccess.Config
{
    class DataAccessConfiguration
    {
        public static string openWeatherApiKey
        {
            get
            {
                return "811a232a18534b7586e3340a260b3334";
            }
        }

        public static string openWeatherApiUrl
        {
            get
            {
                return "https://api.openweathermap.org/data/2.5";
            }
        }

        public static string googleTrafficApiUrl
        {
            get
            {
                return "https://maps.googleapis.com/maps/api/distancematrix/json";
            }
        }

        public static string googleTrafficApiKey
        {
            get
            {
                return "AIzaSyBGoN7HTIWBLk6N9CqEqvJsV_KGFmwt8tw";
            }
        }
    }
}
