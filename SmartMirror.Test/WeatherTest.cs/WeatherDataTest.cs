using SmartMirror.Dataaccess.Entries.Weather;
using SmartMirror.Dataaccess.Repository;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SmartMirror.Test.WeatherTest.cs
{
    public class WeatherDataTest
    {
        private IWeatherRepository _repo;

        public WeatherDataTest()
        {
            _repo = new WeatherRepository();
        }

        [Fact]
        public async Task Can_Retrieve_Weather_Data()
        {
            // Arrange
            Weather_Entries entity = null;
            string city = "London";

            // Act
            entity = await _repo._getWeatherEntityByCityAsync(city);

            // Assert
            Assert.NotNull(entity);
            Assert.Equal(city, entity.Name);
        }

        [Fact]
        public async Task Return_Type_Should_Be_WeatherEntity()
        {
            // Arrange
            string city = "London";

            // Act
            var entity = await _repo._getWeatherEntityByCityAsync(city);

            // Assert
            Assert.IsType<Weather_Entries>(entity);
        }

        [Fact]
        public async Task No_Input_Should_Throw_ArgumentNull()
        {
            // Arrange
            string city = "";

            // Act
            var method = _repo._getWeatherEntityByCityAsync(city);

            // Assert
            await Assert.ThrowsAsync<ArgumentNullException>(async () => await method);
        }

        [Fact]
        public async Task No_City_Found_Should_Throw_HttpRequest()
        {
            // Arrange
            string city = "FEIFJIEFUESFYU";

            // Act & Assert
            var ex = await Assert.ThrowsAsync<HttpRequestException>
                (async () => await _repo._getWeatherEntityByCityAsync(city));
        }
    }
}
