namespace Simply.ServiceAgent.WeatherServiceAgent.Abstractions;

/// <summary>
/// Get weather for city input.
/// </summary>
public class GetWeatherForLocationInput
{
    /// <summary>
    /// Gets or sets longitude.
    /// </summary>
    public double Longitude { get; set; }
    
    /// <summary>
    /// Gets or sets latitude.
    /// </summary>
    public double Latitude { get; set; }
}