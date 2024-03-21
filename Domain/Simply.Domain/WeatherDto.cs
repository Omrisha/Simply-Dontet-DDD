namespace Simply.DomainModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

public class WeatherDto
{
    /// <summary>
    /// Gets or sets current weather.
    /// </summary>
    public CurrentWeatherDto Current { get; set; }

    /// <summary>
    /// Gets or sets forecast.
    /// </summary>
    public ForecastWeatherDto Forecast { get; set; }
}