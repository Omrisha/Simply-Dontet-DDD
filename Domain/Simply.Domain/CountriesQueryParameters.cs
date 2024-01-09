namespace Simply.DomainModel;

using System.Text.Json.Serialization;

/// <summary>
/// Weather by country name query parameters.
/// </summary>
public class CountriesQueryParameters
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [JsonPropertyName("country")]
    public string Country { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [JsonPropertyName("state")]
    public string State { get; set; }
}
