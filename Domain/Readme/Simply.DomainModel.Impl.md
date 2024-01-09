<a name='assembly'></a>
# Simply.DomainModel.Impl

## Contents

- [DomainModelMappingProfile](#T-Simply-DomainModel-Impl-Mappings-DomainModelMappingProfile 'Simply.DomainModel.Impl.Mappings.DomainModelMappingProfile')
  - [#ctor()](#M-Simply-DomainModel-Impl-Mappings-DomainModelMappingProfile-#ctor 'Simply.DomainModel.Impl.Mappings.DomainModelMappingProfile.#ctor')
- [WeatherReader](#T-Simply-DomainModel-Impl-WeatherReader 'Simply.DomainModel.Impl.WeatherReader')
  - [#ctor(logger,mapper,countriesSeviceAgent)](#M-Simply-DomainModel-Impl-WeatherReader-#ctor-Microsoft-Extensions-Logging-ILogger{Simply-DomainModel-Impl-WeatherReader},AutoMapper-IMapper,Simply-ServiceAgent-CountriesServiceAgent-Abstractions-ICountriesSeviceAgent- 'Simply.DomainModel.Impl.WeatherReader.#ctor(Microsoft.Extensions.Logging.ILogger{Simply.DomainModel.Impl.WeatherReader},AutoMapper.IMapper,Simply.ServiceAgent.CountriesServiceAgent.Abstractions.ICountriesSeviceAgent)')
  - [GetCountries(input)](#M-Simply-DomainModel-Impl-WeatherReader-GetCountries-Simply-DomainModel-GetCountriesInput- 'Simply.DomainModel.Impl.WeatherReader.GetCountries(Simply.DomainModel.GetCountriesInput)')
  - [Handle()](#M-Simply-DomainModel-Impl-WeatherReader-Handle-Simply-DomainModel-Cqrs-GetWeatherByCountryNameQuery,System-Threading-CancellationToken- 'Simply.DomainModel.Impl.WeatherReader.Handle(Simply.DomainModel.Cqrs.GetWeatherByCountryNameQuery,System.Threading.CancellationToken)')

<a name='T-Simply-DomainModel-Impl-Mappings-DomainModelMappingProfile'></a>
## DomainModelMappingProfile `type`

##### Namespace

Simply.DomainModel.Impl.Mappings

##### Summary

Domain model mapping profile.

<a name='M-Simply-DomainModel-Impl-Mappings-DomainModelMappingProfile-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [DomainModelMappingProfile](#T-Simply-DomainModel-Impl-Mappings-DomainModelMappingProfile 'Simply.DomainModel.Impl.Mappings.DomainModelMappingProfile') class.

##### Parameters

This constructor has no parameters.

<a name='T-Simply-DomainModel-Impl-WeatherReader'></a>
## WeatherReader `type`

##### Namespace

Simply.DomainModel.Impl

##### Summary

Weather reader.

<a name='M-Simply-DomainModel-Impl-WeatherReader-#ctor-Microsoft-Extensions-Logging-ILogger{Simply-DomainModel-Impl-WeatherReader},AutoMapper-IMapper,Simply-ServiceAgent-CountriesServiceAgent-Abstractions-ICountriesSeviceAgent-'></a>
### #ctor(logger,mapper,countriesSeviceAgent) `constructor`

##### Summary

Initializes a new instance of the [WeatherReader](#T-Simply-DomainModel-Impl-WeatherReader 'Simply.DomainModel.Impl.WeatherReader') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [Microsoft.Extensions.Logging.ILogger{Simply.DomainModel.Impl.WeatherReader}](#T-Microsoft-Extensions-Logging-ILogger{Simply-DomainModel-Impl-WeatherReader} 'Microsoft.Extensions.Logging.ILogger{Simply.DomainModel.Impl.WeatherReader}') | A [ILogger\`1](#T-Microsoft-Extensions-Logging-ILogger`1 'Microsoft.Extensions.Logging.ILogger`1') instnace. |
| mapper | [AutoMapper.IMapper](#T-AutoMapper-IMapper 'AutoMapper.IMapper') | A [IMapper](#T-AutoMapper-IMapper 'AutoMapper.IMapper') instance. |
| countriesSeviceAgent | [Simply.ServiceAgent.CountriesServiceAgent.Abstractions.ICountriesSeviceAgent](#T-Simply-ServiceAgent-CountriesServiceAgent-Abstractions-ICountriesSeviceAgent 'Simply.ServiceAgent.CountriesServiceAgent.Abstractions.ICountriesSeviceAgent') | A [ICountriesSeviceAgent](#T-Simply-ServiceAgent-CountriesServiceAgent-Abstractions-ICountriesSeviceAgent 'Simply.ServiceAgent.CountriesServiceAgent.Abstractions.ICountriesSeviceAgent') instance. |

<a name='M-Simply-DomainModel-Impl-WeatherReader-GetCountries-Simply-DomainModel-GetCountriesInput-'></a>
### GetCountries(input) `method`

##### Summary

Get countries logic.

##### Returns

A task containing [IQueryable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable`1 'System.Linq.IQueryable`1') instnace.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [Simply.DomainModel.GetCountriesInput](#T-Simply-DomainModel-GetCountriesInput 'Simply.DomainModel.GetCountriesInput') | A [GetCountriesInput](#T-Simply-DomainModel-GetCountriesInput 'Simply.DomainModel.GetCountriesInput') instnace. |

<a name='M-Simply-DomainModel-Impl-WeatherReader-Handle-Simply-DomainModel-Cqrs-GetWeatherByCountryNameQuery,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.
