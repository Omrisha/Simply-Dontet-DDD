namespace Simply.ServiceAgent.WeatherServiceAgent.Abstractions;

using System.Text.Json.Serialization;

/// <summary>
/// Condition model.
/// </summary>
public class ConditionModel
{
    /// <summary>
    /// Gets or sets text.
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; set; }

    /// <summary>
    /// Gets or sets icon.
    /// </summary>
    [JsonPropertyName("icon")]
    public string Icon { get; set; }
}
