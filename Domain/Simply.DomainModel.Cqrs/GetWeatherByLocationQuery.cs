using MediatR;

namespace Simply.DomainModel.Cqrs;

/// <summary>
/// Get weather by country name input.
/// </summary>
public record GetWeatherByLocationQuery(GetWeathByLocationInput Input) : IRequest<WeatherByLocationDto>;