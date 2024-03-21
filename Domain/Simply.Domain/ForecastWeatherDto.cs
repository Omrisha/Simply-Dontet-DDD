namespace Simply.DomainModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

public class ForecastWeatherDto
{
    /// <summary>
    /// Gets or sets forecast.
    /// </summary>
    public ForecastDto[] Forecasts { get; set; }
}