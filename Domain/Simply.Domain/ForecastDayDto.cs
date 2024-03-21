namespace Simply.DomainModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

public class ForecastDayDto
{
    /// <summary>
    /// Gets or sets Temperature Celcius.
    /// </summary>
    public double MaxTemperatureCelcius { get; set; }

    /// <summary>
    /// Gets or sets Temperature Farenheit.
    /// </summary>
    public double MaxTemperatureFarenheit { get; set; }

    /// <summary>
    /// Gets or sets Temperature Celcius.
    /// </summary>
    public double MinTemperatureCelcius { get; set; }

    /// <summary>
    /// Gets or sets Temperature Farenheit.
    /// </summary>
    public double MinTemperatureFarenheit { get; set; }

    /// <summary>
    /// Gets or sets Temperature Celcius.
    /// </summary>
    public double AverageTemperatureCelcius { get; set; }

    /// <summary>
    /// Gets or sets Temperature Farenheit.
    /// </summary>
    public double AverageTemperatureFarenheit { get; set; }

    /// <summary>
    /// Gets or sets condition.
    /// </summary>
    public ConditionDto Condition { get; set; }
}