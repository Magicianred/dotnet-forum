using System;
using System.Runtime.Serialization;

namespace DotnetForum.Payloads
{
    [DataContract]
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public WeatherSummary Summary { get; set; }
    }
}
