namespace Simply.DomainModel.Cqrs;

using MediatR;

/// <summary>
/// Get weather by country name input.
/// </summary>
public record GeCountriesQuery(GetCountriesInput Input) : IRequest<ICollection<CountryDto>>;