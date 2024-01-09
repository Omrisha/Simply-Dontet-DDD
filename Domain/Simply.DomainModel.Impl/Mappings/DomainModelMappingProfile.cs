namespace Simply.DomainModel.Impl.Mappings;

using AutoMapper;
using Simply.EntityModel;
using Simply.ServiceAgent.CountriesServiceAgent.Abstractions;

/// <summary>
/// Domain model mapping profile.
/// </summary>
public class DomainModelMappingProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DomainModelMappingProfile"/> class.
    /// </summary>
    public DomainModelMappingProfile()
    {
        this.CreateMap<GetCountriesInput, GetCountriesWithStatesInput>();
        this.CreateMap<GetCountriesInput, GetCountriesWithCitiesInput>();
        this.CreateMap<CountryWithStatesDataModel, CountryDto>()
            .ForMember(d => d.Name, m => m.MapFrom(s => s.Name));

        this.CreateMap<StateDataModel, StateDto>()
            .ForMember(d => d.Name, m => m.MapFrom(s => s.Name));
    }
}