namespace Simply.ServiceAgent.CountriesServiceAgent.Abstractions;

using System.Text.Json.Serialization;

/// <summary>
/// Get rate by country filter output.
/// </summary>
public class GetRateByCountryFilterOutput
{
    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    [JsonPropertyName("data")]
    public List<CountryRateDataModel> Data { get; set; }
}