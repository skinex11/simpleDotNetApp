using System;
using Xunit;

namespace patryk.konopka.service2.tests
{
    public class UnitTest1
    {
        [Fact]
        public void isTemperatureCorrect()
        {
            var weatherForecast = new WeatherForecast();
            var TemperatureC = weatherForecast.TemperatureC;
            bool result = TemperatureC > -273;

            Assert.True(result);
        }
    }
}
