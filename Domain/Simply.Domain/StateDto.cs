namespace Simply.DomainModel;

using System.Text.Json.Serialization;

/// <summary>
/// State data transfer object.
/// </summary>
public class StateDto
{
    /// <summary>
    /// Gets or sets the country name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the country name.
    /// </summary>
    public string StateCode { get; set; }
}