namespace Simply.Services.Graphql.Mappings;

using AutoMapper;
using Simply.DomainModel;

/// <summary>
/// Graphql model mapping profile.
/// </summary>
public class GraphqlModelMappingProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DomainModelMappingProfile"/> class.
    /// </summary>
    public GraphqlModelMappingProfile()
    {
        this.CreateMap<CountriesQueryParameters, GetCountriesInput>();
    }
}