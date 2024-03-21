namespace Simply.DomainModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

public class CurrentWeatherDto
{
    /// <summary>
    /// Gets or sets Temperature Celcius.
    /// </summary>
    public double TemperatureCelcius { get; set; }

    /// <summary>
    /// Gets or sets Temperature Farenheit.
    /// </summary>
    public double TemperatureFarenheit { get; set; }

    /// <summary>
    /// Gets or sets condition.
    /// </summary>
    public ConditionDto Condition { get; set; }
}