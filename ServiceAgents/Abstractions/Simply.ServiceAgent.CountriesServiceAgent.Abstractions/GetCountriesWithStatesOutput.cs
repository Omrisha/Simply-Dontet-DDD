namespace Simply.ServiceAgent.CountriesServiceAgent.Abstractions;

using System.Text.Json.Serialization;

/// <summary>
/// Gets or sets countries filter input.
/// </summary>
public class GetCountriesWithStatesOutput
{
    /// <summary>
    /// Gets or sets the name;
    /// </summary>
    [JsonPropertyName("data")]
    public List<CountryWithStatesDataModel> Data { get; set; }
}