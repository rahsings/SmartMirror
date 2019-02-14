using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SmartMirror.Dataaccess.Entries.Weather;

namespace SmartMirror.Dataaccess.Repository
{
    public interface IWeatherRepository
    {
        Task<Weather_Entries> _getWeatherEntityByCityAsync(string city);
    }
}
