namespace Simply.EntityModel;

/// <summary>
/// Country entity.
/// </summary>
public class CountryEntity
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

