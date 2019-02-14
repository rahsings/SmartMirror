using SmartMirror.Dataaccess.Entries.Traffic;
using SmartMirror.Dataaccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SmartMirror.Test.TrafficTest.cs
{
    public class TrafficDataTest
    {
        private ITrafficRepository _repo;

        public TrafficDataTest()
        {
            _repo = new TrafficRepository();
        }

        [Fact]
        public async Task Can_Retrieve_Traffic_Data()
        {
            // Arrange
            Traffic_Entity entity = null;
            string start = "London, UK";
            string destination = "Brighton, UK";

            // Act
            entity = await _repo._getTrafficEntityAsync(start, destination);

            // Assert
            Assert.NotNull(entity);
            Assert.Equal("OK", entity.status);
        }

        [Fact]
        public async Task Return_Type_Should_Be_TrafficEntity()
        {
            // Arrange
            string start = "London, UK";
            string destination = "Brighton, UK";

            // Act
            var entity = await _repo._getTrafficEntityAsync(start, destination);

            // Assert
            Assert.IsType<Traffic_Entity>(entity);
        }

        [Fact]
        public async Task Empty_Input_Should_Throw_ArgumentNull()
        {
            // Arrange
            string start = "";
            string destination = "Brighton, UK";

            // Act & Assert
            var ex = await Assert.ThrowsAsync<ArgumentNullException>
                (async () => await _repo._getTrafficEntityAsync(start, destination));
        }
        /*  [Fact]
         public async Task No_Traffic_Found_Should_Throw_HttpRequest()
          {
              // Arrange
              string start = "FEIFJIEFUESFYU";
              string destination = "FOOBARTYRAS";

              // Act & Assert
              var ex = await Assert.ThrowsAsync<HttpRequestException>
                  (async () => await _repo._getTrafficEntityAsync(start, destination));
          }*/
    }
}
