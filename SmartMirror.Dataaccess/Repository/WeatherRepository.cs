using SmartMirror.Dataaccess.Config;
using SmartMirror.Dataaccess.Entries.Weather;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SmartMirror.Dataaccess.Repository
{
    public class WeatherRepository : Repository<Weather_Entries>, IWeatherRepository
    {
        private string _city;

        public async Task<Weather_Entries> _getWeatherEntityByCityAsync(string city)
        {
            _inputData(city);
            HttpResponseMessage message = await _getResponseMessageAsync();
            Weather_Entries entries = await _getWeatherEntityFromJsonAsync(message);

            return entries;
        }

        protected override void validate()
        {
            base.validate();
            if (string.IsNullOrWhiteSpace(_city))
            {
                throw new ArgumentNullException("Home City Required");
            }
        }
        private void _inputData(string city)
        {

            _apikey = DataAccessConfiguration.openWeatherApiKey;
            _apiurl = DataAccessConfiguration.openWeatherApiUrl;
            _city = city;

            validate();
            _url = $"{_apiurl}/weather?q={_city}&appid={_apikey}"; //interpolated string
        }
    }
}
