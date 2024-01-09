namespace Simply.DomainModel;

/// <summary>
/// Get weather by country name input.
/// </summary>
/// <param name="Country">Country name.</param>
/// <param name="State">State name.</param>
public record GetCountriesInput(string Country = null, string State = null);