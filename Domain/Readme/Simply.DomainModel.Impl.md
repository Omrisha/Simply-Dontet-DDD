<a name='assembly'></a>
# Simply.DomainModel.Impl

## Contents

- [CountryReader](#T-Simply-DomainModel-Impl-CountryReader 'Simply.DomainModel.Impl.CountryReader')
  - [#ctor(logger,mapper,httpClientFactory)](#M-Simply-DomainModel-Impl-CountryReader-#ctor-Microsoft-Extensions-Logging-ILogger{Simply-DomainModel-Impl-CountryReader},AutoMapper-IMapper,System-Net-Http-IHttpClientFactory- 'Simply.DomainModel.Impl.CountryReader.#ctor(Microsoft.Extensions.Logging.ILogger{Simply.DomainModel.Impl.CountryReader},AutoMapper.IMapper,System.Net.Http.IHttpClientFactory)')
  - [GetCountries(getCountriesInput)](#M-Simply-DomainModel-Impl-CountryReader-GetCountries-Simply-DomainModel-GetCountriesInput- 'Simply.DomainModel.Impl.CountryReader.GetCountries(Simply.DomainModel.GetCountriesInput)')
  - [Handle()](#M-Simply-DomainModel-Impl-CountryReader-Handle-Simply-DomainModel-Cqrs-GetCountriesQuery,System-Threading-CancellationToken- 'Simply.DomainModel.Impl.CountryReader.Handle(Simply.DomainModel.Cqrs.GetCountriesQuery,System.Threading.CancellationToken)')
- [DomainModelMappingProfile](#T-Simply-DomainModel-Impl-Mappings-DomainModelMappingProfile 'Simply.DomainModel.Impl.Mappings.DomainModelMappingProfile')
  - [#ctor()](#M-Simply-DomainModel-Impl-Mappings-DomainModelMappingProfile-#ctor 'Simply.DomainModel.Impl.Mappings.DomainModelMappingProfile.#ctor')

<a name='T-Simply-DomainModel-Impl-CountryReader'></a>
## CountryReader `type`

##### Namespace

Simply.DomainModel.Impl

##### Summary

Country reader.

<a name='M-Simply-DomainModel-Impl-CountryReader-#ctor-Microsoft-Extensions-Logging-ILogger{Simply-DomainModel-Impl-CountryReader},AutoMapper-IMapper,System-Net-Http-IHttpClientFactory-'></a>
### #ctor(logger,mapper,httpClientFactory) `constructor`

##### Summary

Initializes a new instance of the [CountryReader](#T-Simply-DomainModel-Impl-CountryReader 'Simply.DomainModel.Impl.CountryReader') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [Microsoft.Extensions.Logging.ILogger{Simply.DomainModel.Impl.CountryReader}](#T-Microsoft-Extensions-Logging-ILogger{Simply-DomainModel-Impl-CountryReader} 'Microsoft.Extensions.Logging.ILogger{Simply.DomainModel.Impl.CountryReader}') | A [ILogger\`1](#T-Microsoft-Extensions-Logging-ILogger`1 'Microsoft.Extensions.Logging.ILogger`1') instnace. |
| mapper | [AutoMapper.IMapper](#T-AutoMapper-IMapper 'AutoMapper.IMapper') | A [IMapper](#T-AutoMapper-IMapper 'AutoMapper.IMapper') instance. |
| httpClientFactory | [System.Net.Http.IHttpClientFactory](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.IHttpClientFactory 'System.Net.Http.IHttpClientFactory') | A [IHttpClientFactory](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.IHttpClientFactory 'System.Net.Http.IHttpClientFactory') instance. |

<a name='M-Simply-DomainModel-Impl-CountryReader-GetCountries-Simply-DomainModel-GetCountriesInput-'></a>
### GetCountries(getCountriesInput) `method`

##### Summary

Get countries logic.

##### Returns

A task containing [IQueryable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable`1 'System.Linq.IQueryable`1') instnace.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| getCountriesInput | [Simply.DomainModel.GetCountriesInput](#T-Simply-DomainModel-GetCountriesInput 'Simply.DomainModel.GetCountriesInput') | A [GetCountriesInput](#T-Simply-DomainModel-GetCountriesInput 'Simply.DomainModel.GetCountriesInput') instnace. |

<a name='M-Simply-DomainModel-Impl-CountryReader-Handle-Simply-DomainModel-Cqrs-GetCountriesQuery,System-Threading-CancellationToken-'></a>
### Handle() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

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
