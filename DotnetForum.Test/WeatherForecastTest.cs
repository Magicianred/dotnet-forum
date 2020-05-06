using DotnetForum.Contracts;
using DotnetForum.WebApi.Services;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.CompilerServices;
using Moq;
using System;
using System.Linq;
using DotnetForum.Contracts.Services;

namespace DotnetForum.Test
{
    [TestClass]
    public class WeatherForecastTest
    {
        private ILogger<WeatherForecastService> logger;
        private IRandomizerService randomizerService;

        private WeatherForecastService weatherForecastService;

        [TestInitialize]
        public void Setup()
        {
            logger = new Mock<ILogger<WeatherForecastService>>().Object;
            randomizerService = new Mock<IRandomizerService>().Object;

            weatherForecastService = new WeatherForecastService(
                logger, randomizerService);
        }

        [TestMethod]
        public void ForecastTest()
        {
            var items = weatherForecastService.GetForecasts();

            Assert.IsNotNull(items);
            Assert.AreNotEqual(0, items.Count());
        }
    }
}
