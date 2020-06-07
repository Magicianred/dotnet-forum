using DotnetForum.Contracts;
using DotnetForum.Contracts.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace DotnetForum.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IWeatherForecastService weatherForecastService)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            _logger.LogInformation($"GET {nameof(WeatherForecastController)} invoked.");
            return _weatherForecastService.GetForecasts();
        }
    }
}
