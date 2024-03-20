namespace Simply.ServiceAgent.CountriesServiceAgent.Abstractions;

using System.Text.Json.Serialization;

/// <summary>
/// Country rate data model.
/// </summary>
public class CountryRateDataModel
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets currency.
    /// </summary>
    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Gets or sets the three letter code.
    /// </summary>
    [JsonPropertyName("iso2")]
    public string TwoLetterCode { get; set; }

    /// <summary>
    /// Gets or sets the three letter code.
    /// </summary>
    [JsonPropertyName("iso3")]
    public string ThreeLetterCode { get; set; }
}