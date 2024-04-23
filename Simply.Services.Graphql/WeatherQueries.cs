using AutoMapper;
using HotChocolate;
using MediatR;
using Simply.DomainModel;
using Simply.DomainModel.Cqrs;

namespace Simply.Services.Graphql;

[ExtendObjectType("Query")]
public class WeatherQueries
{
    /// <summary>
    /// Get countries query.
    /// </summary>
    /// <param name="mediator">A <see cref="IMediator"/> instance.</param>
    /// <param name="filter">Country name to search weather for.</param>
    /// <returns></returns>
    [Serial]
    public async Task<WeatherDto> GetWeather([Service] IMediator mediator, [Service] IMapper mapper, WeatherQueryParameters? filter = null)
    {
        GetWeatherByCityInput getCountriesInput = filter != null ? mapper.Map<WeatherQueryParameters, GetWeatherByCityInput>(filter) : new();
        return await mediator.Send(new GetWeatherByCityNameQuery(getCountriesInput));
    }
    
    /// <summary>
    /// Get countries query.
    /// </summary>
    /// <param name="mediator">A <see cref="IMediator"/> instance.</param>
    /// <param name="filter">Country name to search weather for.</param>
    /// <returns></returns>
    [Serial]
    public async Task<WeatherByLocationDto> GetWeatherByLocation([Service] IMediator mediator, [Service] IMapper mapper, WeatherByLocationQueryParameters? filter = null)
    {
        GetWeathByLocationInput getCountriesInput = filter != null ? mapper.Map<WeatherByLocationQueryParameters, GetWeathByLocationInput>(filter) : new();
        return await mediator.Send(new GetWeatherByLocationQuery(getCountriesInput));
    }
}

