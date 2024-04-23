namespace Simply.DomainModel.Impl.Mappings;

using AutoMapper;
using Simply.EntityModel;
using Simply.ServiceAgent.CountriesServiceAgent.Abstractions;
using Simply.ServiceAgent.WeatherServiceAgent.Abstractions;

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

        this.CreateMap<GetWeatherByCityInput, GetWeatherForCityInput>();

        this.CreateMap<GetWeatherForCityOutput, WeatherDto>();
        this.CreateMap<CurrentWeatherModel, CurrentWeatherDto>();
        this.CreateMap<ForecastWeatherModel, ForecastWeatherDto>();
        this.CreateMap<ConditionModel, ConditionDto>()
            .ForMember(d => d.Icon, m => m.MapFrom(s => "https:" + s.Icon));
        this.CreateMap<ForecastModel, ForecastDto>();
        this.CreateMap<ForecastDayModel, ForecastDayDto>();

        this.CreateMap<GetWeathByLocationInput, GetWeatherForLocationInput>();
        this.CreateMap<GetWeatherForLocationOutput, WeatherByLocationDto>();
        this.CreateMap<HourlyModel, HourlyDto>();
    }
}