namespace Simply.ServiceAgent.CountriesServiceAgent.Abstractions;

using System.Text.Json.Serialization;

/// <summary>
/// Country data model.
/// </summary>
public class CountryWithStatesDataModel
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the three letter code.
    /// </summary>
    [JsonPropertyName("iso3")]
    public string ThreeLetterCode { get; set; }

    /// <summary>
    /// Gets or sets the cities.
    /// </summary>
    [JsonPropertyName("states")]
    public List<StateDataModel> States { get; set; }
}