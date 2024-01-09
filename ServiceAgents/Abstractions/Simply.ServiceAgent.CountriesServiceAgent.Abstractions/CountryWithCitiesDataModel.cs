namespace Simply.ServiceAgent.CountriesServiceAgent.Abstractions;

using System.Text.Json.Serialization;

/// <summary>
/// Country data model.
/// </summary>
public class CountryWithCitiesDataModel
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [JsonPropertyName("country")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the three letter code.
    /// </summary>
    [JsonPropertyName("iso2")]
    public string TowLetterCode { get; set; }

    /// <summary>
    /// Gets or sets the three letter code.
    /// </summary>
    [JsonPropertyName("iso3")]
    public string ThreeLetterCode { get; set; }

    /// <summary>
    /// Gets or sets the cities.
    /// </summary>
    [JsonPropertyName("cities")]
    public List<string> Cities { get; set; }
}