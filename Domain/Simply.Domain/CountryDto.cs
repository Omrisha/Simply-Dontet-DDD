namespace Simply.DomainModel;

using System.Text.Json.Serialization;

/// <summary>
/// Country data transfer object.
/// </summary>
public class CountryDto
{
    /// <summary>
    /// Gets or sets the country name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the three letter code.
    /// </summary>
    public string ThreeLetterCode { get; set; }

    /// <summary>
    /// Gets or sets the cities.
    /// </summary>
    public List<string> Cities { get; set; }

    /// <summary>
    /// Gets or sets the states.
    /// </summary>
    public List<StateDto> States { get; set; }
}