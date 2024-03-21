namespace Simply.DomainModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

public class ForecastDto
{
    /// <summary>
    /// Gets or sets date.
    /// </summary>
    [JsonPropertyName("date")]
    public string Date { get; set; }

    /// <summary>
    /// Gets or sets day forecast.
    /// </summary>
    [JsonPropertyName("day")]
    public ForecastDayDto Day { get; set; }
}
