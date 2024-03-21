using MediatR;

namespace Simply.DomainModel.Cqrs;

/// <summary>
/// Get weather by country name input.
/// </summary>
public record GetCityAndRatesQuery(GetCityAndRatesInput Input) : IRequest<ICollection<CityDto>>;