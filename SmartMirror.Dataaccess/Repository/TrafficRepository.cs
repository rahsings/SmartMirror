using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using SmartMirror.Dataaccess.Config;
using SmartMirror.Dataaccess.Entries.Traffic;

namespace SmartMirror.Dataaccess.Repository
{
    public class TrafficRepository : Repository<Traffic_Entity>, ITrafficRepository
    {
        private string _source;
        private string _destination;
        public async Task<Traffic_Entity> _getTrafficEntityAsync(string source, string destination)
        {
            _inputData(source, destination);
            HttpResponseMessage message = await _getResponseMessageAsync();
            Traffic_Entity entries = await _getWeatherEntityFromJsonAsync(message);
            return entries;
        }

        protected override void validate()
        {
            base.validate();
            if (string.IsNullOrWhiteSpace(_source))
            {
                throw new ArgumentNullException("Source Required");
            }
            if (string.IsNullOrWhiteSpace(_destination))
            {
                throw new ArgumentNullException("Destination Required");
            }
        }
        private void _inputData(string source, string destination)
        {

            _apikey = DataAccessConfiguration.googleTrafficApiKey;
            _apiurl = DataAccessConfiguration.googleTrafficApiUrl;
            _source = source;
            _destination = destination;

            validate();
            _url = $"{_apiurl}?origins={source}&destinations={destination}&key={_apikey}"; //interpolated string
        }
    }
}
