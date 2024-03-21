namespace Simply.DomainModel;

using System.Text.Json.Serialization;

/// <summary>
/// Weather by country name query parameters.
/// </summary>
public class WeatherQueryParameters
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    public string CityName { get; set; }
}
