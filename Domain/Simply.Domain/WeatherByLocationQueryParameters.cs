namespace Simply.DomainModel;

/// <summary>
/// Weather by country name query parameters.
/// </summary>
public class WeatherByLocationQueryParameters
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