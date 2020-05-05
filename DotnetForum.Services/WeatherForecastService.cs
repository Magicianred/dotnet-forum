using DotnetForum.Contracts;
using DotnetForum.Payloads;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DotnetForum.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly ILogger<WeatherForecastService> _logger;
        private readonly IRandomizerService _randomizer;

        public WeatherForecastService(
            ILogger<WeatherForecastService> logger,
            IRandomizerService randomizer)
        {
            _logger = logger;
            _randomizer = randomizer;
        }

        public IEnumerable<WeatherForecast> GetForecasts()
        {
            _logger.LogDebug($"{nameof(GetForecasts)} invoked.");

            var items = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = _randomizer.GetNextNumber(-20, 55),
                Summary = (WeatherSummary)_randomizer.GetNextNumber(
                    (int)WeatherSummary.Freezing, 
                    (int)WeatherSummary.Scorching),
            }).ToArray();

            _logger.LogDebug($"Total {items.Length} item(s) populated.");

            return items;
        }
    }
}
