namespace Simply.DomainModel;

/// <summary>
/// Get weather by location input.
/// </summary>
public class GetWeathByLocationInput
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