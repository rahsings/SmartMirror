using System;
using System.Collections.Generic;
using System.Text;
using SmartMirror.ConsoleApp.Models;

namespace SmartMirror.ConsoleApp
{
    class Main
    {
        private UserDetails _userdetails;
        private TemperatureDetails _temperaturedetails;
        private TimeDetails _timedetails;
        public void Run()
        {
            _userdetails = getUserDetails();
            _temperaturedetails = getTemperatureDetails();
            _timedetails = getTimeDetails();

            getOutput();
            Console.ReadLine();
        }

        private UserDetails getUserDetails()
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your address:");
            string address = Console.ReadLine();

            Console.WriteLine("Please enter your zipcode:");
            string zipcode = Console.ReadLine();

            Console.WriteLine("Please enter your city:");
            string town = Console.ReadLine();

            Console.WriteLine("Please enter your work address:");
            string workAddress = Console.ReadLine();

            var result = new UserDetails
            {
                name = name,
                address = address,
                zipCode = zipcode,
                city = town,
                workAddress = workAddress
            };

            return result;
        }

        private TemperatureDetails getTemperatureDetails()
        {
            return new TemperatureDetails
            {
                Location = "London",
                Sunrise = "6:04",
                Sunset = "18:36",
                Temperature = 17,
                WeatherType = "Sunny",
                TemperatureUOM = "Celsius",
            };
        }

        private TimeDetails getTimeDetails()
        {
            return new TimeDetails
            {
                Minutes = 35,
                Distance = 27,
                DistanceUOM = "Kilometers",
                Destination = "2 St Margaret St, London"
            };
        }

        private void getOutput()
        {
            Console.WriteLine($"Good {GetTimeOfDay()} {_userdetails.name}");
            Console.WriteLine($"The current time is {DateTime.Now.ToShortTimeString()} and the outside weather is {_temperaturedetails.WeatherType}.");
            Console.WriteLine($"Current topside temperature is {_temperaturedetails.Temperature} degrees {_temperaturedetails.TemperatureUOM}.");
            Console.WriteLine($"The sun has risen at {_temperaturedetails.Sunrise} and will set at approximetely {_temperaturedetails.Sunset}.");
            Console.WriteLine($"Your trip to work will take about {_timedetails.Minutes} minutes. " +
                $"If you leave now, you should arrive at approximately {_timedetails.TimeOfArrival.ToShortTimeString()}.");
            Console.WriteLine("Thank you, and have a very safe and productive day!");
        }

        private string GetTimeOfDay()
        {
            var currentTime = DateTime.Now.TimeOfDay.Hours;

            if (currentTime >= 0 && currentTime <= 11)
                return "morning";
            else if (currentTime <= 13)
                return "day";
            else if (currentTime <= 18)
                return "afternoon";
            else if (currentTime <= 22)
                return "evening";
            else
                return "night";
        }
    }
}
