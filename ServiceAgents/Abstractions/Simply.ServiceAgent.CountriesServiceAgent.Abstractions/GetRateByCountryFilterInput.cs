namespace Simply.ServiceAgent.CountriesServiceAgent.Abstractions;

using System.Text.Json.Serialization;

/// <summary>
/// Get rate by country filter input.
/// </summary>
public class GetRateByCountryFilterInput
{
    /// <summary>
    /// Gets or sets two letter code of a country.
    /// </summary>
    [JsonPropertyName("iso2")]
    public string TwoLetterCode { get; set; }
}