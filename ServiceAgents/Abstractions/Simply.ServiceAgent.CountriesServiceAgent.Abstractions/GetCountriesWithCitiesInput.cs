namespace Simply.ServiceAgent.CountriesServiceAgent.Abstractions;

using System.Text.Json.Serialization;

/// <summary>
/// Gets or sets countries filter input.
/// </summary>
public class GetCountriesWithCitiesInput
{
    /// <summary>
    /// Gets or sets the name;
    /// </summary>
    [JsonPropertyName("country")]
    public string Country { get; set; }

    /// <summary>
    /// Gets or sets the name;
    /// </summary>
    [JsonPropertyName("state")]
    public string State { get; set; }
}