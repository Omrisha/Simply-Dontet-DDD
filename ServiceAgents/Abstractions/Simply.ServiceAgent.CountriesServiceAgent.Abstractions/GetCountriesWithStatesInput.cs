namespace Simply.ServiceAgent.CountriesServiceAgent.Abstractions;

using System.Text.Json.Serialization;

/// <summary>
/// Gets or sets countries filter input.
/// </summary>
public class GetCountriesWithStatesInput
{
    /// <summary>
    /// Gets or sets the name;
    /// </summary>
    [JsonPropertyName("country")]
    public string Country { get; set; }
}