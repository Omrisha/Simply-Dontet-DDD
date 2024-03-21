using AutoMapper;
using HotChocolate;
using MediatR;
using Simply.DomainModel;
using Simply.DomainModel.Cqrs;

namespace Simply.Services.Graphql;

[ExtendObjectType("Query")]
public class CountriesQueries
{
    /// <summary>
    /// Get countries query.
    /// </summary>
    /// <param name="mediator">A <see cref="IMediator"/> instance.</param>
    /// <param name="filter">Country name to search weather for.</param>
    /// <returns></returns>
    [Serial]
    public async Task<ICollection<CountryDto>> GetCountries([Service] IMediator mediator, [Service] IMapper mapper, CountriesQueryParameters? filter = null)
    {
        GetCountriesInput getCountriesInput = filter != null ? mapper.Map<CountriesQueryParameters, GetCountriesInput>(filter) : new();
        return await mediator.Send(new GeCountriesQuery(getCountriesInput));
    }
    
    /// <summary>
    /// Get countries query.
    /// </summary>
    /// <param name="mediator">A <see cref="IMediator"/> instance.</param>
    /// <param name="filter">Country name to search weather for.</param>
    /// <returns></returns>
    [Serial]
    public async Task<ICollection<CityDto>> GetCityAndRates([Service] IMediator mediator, [Service] IMapper mapper, CityAndRatesQueryParameters? filter = null)
    {
        GetCityAndRatesInput input = filter != null ? mapper.Map<CityAndRatesQueryParameters, GetCityAndRatesInput>(filter) : new();
        return await mediator.Send(new GetCityAndRatesQuery(input));
    }
}

