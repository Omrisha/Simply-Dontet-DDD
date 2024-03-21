namespace Simply.DomainModel.Cqrs;

using MediatR;

/// <summary>
/// Get weather by country name input.
/// </summary>
public record GetWeatherByCityNameQuery(GetWeatherByCityInput Input) : IRequest<WeatherDto>;