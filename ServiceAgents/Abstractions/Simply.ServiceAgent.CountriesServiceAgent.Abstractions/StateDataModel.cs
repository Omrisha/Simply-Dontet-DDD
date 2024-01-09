namespace Simply.ServiceAgent.CountriesServiceAgent.Abstractions;

using System.Text.Json.Serialization;

/// <summary>
/// State data model.
/// </summary>
public class StateDataModel
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the state_code.
    /// </summary>
    [JsonPropertyName("state_code")]
    public string StateCode { get; set; }
}
