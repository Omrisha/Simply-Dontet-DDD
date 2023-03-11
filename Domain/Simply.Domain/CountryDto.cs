namespace Simply.DomainModel;

/// <summary>
/// Get Country input.
/// </summary>
public class CountryDto
{
    /// <summary>
    /// Gets or sets the country name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the cities.
    /// </summary>
    public List<string> Cities { get; set; }
}