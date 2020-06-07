using System.Collections.Generic;

namespace DotnetForum.Contracts.Services
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> GetForecasts();
    }
}