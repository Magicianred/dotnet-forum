using DotnetForum.Payloads;
using System.Collections.Generic;

namespace DotnetForum.Contracts
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> GetForecasts();
    }
}