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
    /// <param name="name">Country name to search weather for.</param>
    /// <returns></returns>
    [Serial]
    public static async Task<ICollection<CountryDto>> GetWeatherForCountryName([Service] IMediator mediator, string name)
    {
        return await mediator.Send(new GetWeatherByCountryNameQuery(new(name)));
    }
}

