namespace Simply.DomainModel.Cqrs;

using MediatR;

/// <summary>
/// Get weather by country name input.
/// </summary>
public record GetWeatherByCountryNameQuery(GetWeatherByCountryNameInput GetCountriesInput) : IRequest<ICollection<CountryDto>>;