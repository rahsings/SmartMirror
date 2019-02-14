using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SmartMirror.Dataaccess.Repository
{
    public class Repository<T>
    {
        protected string _apikey;
        protected string _apiurl;
        protected string _url;

        protected virtual void validate()
        {
            if (string.IsNullOrWhiteSpace(_apikey))
            {
                throw new ArgumentNullException("API key Required");
            }

            if (string.IsNullOrWhiteSpace(_apiurl))
            {
                throw new ArgumentNullException("API url Required");
            }
        }
        protected async Task<HttpResponseMessage> _getResponseMessageAsync()
        {
            var client = new HttpClient();
            HttpResponseMessage message = await client.GetAsync(_url);

            if (!message.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Cannot connect to api: {message.StatusCode} {message.ReasonPhrase}");
            }
            return message;
        }

        protected async Task<T> _getWeatherEntityFromJsonAsync(HttpResponseMessage message)
        {
            string json = await message.Content.ReadAsStringAsync();
            try
            {
                var result = JsonConvert.DeserializeObject<T>(json);
                return result;
            }
            catch (Exception e)
            {
                throw new JsonSerializationException("Cannot Convert From Entries", e);
            }
        }
    }
}
