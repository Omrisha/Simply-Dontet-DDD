namespace Simply.DomainModel;

using System.Text.Json.Serialization;

public class CityDto
{
    /// <summary>
    /// Gets or sets the country name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the three letter code.
    /// </summary>
    public string Currency { get; set; }
}