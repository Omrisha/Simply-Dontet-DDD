<a name='assembly'></a>
# Simply.Domain

## Contents

- [CountriesQueryParameters](#T-Simply-DomainModel-CountriesQueryParameters 'Simply.DomainModel.CountriesQueryParameters')
  - [Country](#P-Simply-DomainModel-CountriesQueryParameters-Country 'Simply.DomainModel.CountriesQueryParameters.Country')
  - [State](#P-Simply-DomainModel-CountriesQueryParameters-State 'Simply.DomainModel.CountriesQueryParameters.State')
- [CountryDto](#T-Simply-DomainModel-CountryDto 'Simply.DomainModel.CountryDto')
  - [Cities](#P-Simply-DomainModel-CountryDto-Cities 'Simply.DomainModel.CountryDto.Cities')
  - [Name](#P-Simply-DomainModel-CountryDto-Name 'Simply.DomainModel.CountryDto.Name')
  - [States](#P-Simply-DomainModel-CountryDto-States 'Simply.DomainModel.CountryDto.States')
  - [ThreeLetterCode](#P-Simply-DomainModel-CountryDto-ThreeLetterCode 'Simply.DomainModel.CountryDto.ThreeLetterCode')
- [GetCityInput](#T-Simply-DomainModel-GetCityInput 'Simply.DomainModel.GetCityInput')
  - [Name](#P-Simply-DomainModel-GetCityInput-Name 'Simply.DomainModel.GetCityInput.Name')
- [GetCountriesInput](#T-Simply-DomainModel-GetCountriesInput 'Simply.DomainModel.GetCountriesInput')
  - [#ctor(Country,State)](#M-Simply-DomainModel-GetCountriesInput-#ctor-System-String,System-String- 'Simply.DomainModel.GetCountriesInput.#ctor(System.String,System.String)')
  - [Country](#P-Simply-DomainModel-GetCountriesInput-Country 'Simply.DomainModel.GetCountriesInput.Country')
  - [State](#P-Simply-DomainModel-GetCountriesInput-State 'Simply.DomainModel.GetCountriesInput.State')
- [StateDto](#T-Simply-DomainModel-StateDto 'Simply.DomainModel.StateDto')
  - [Name](#P-Simply-DomainModel-StateDto-Name 'Simply.DomainModel.StateDto.Name')
  - [StateCode](#P-Simply-DomainModel-StateDto-StateCode 'Simply.DomainModel.StateDto.StateCode')

<a name='T-Simply-DomainModel-CountriesQueryParameters'></a>
## CountriesQueryParameters `type`

##### Namespace

Simply.DomainModel

##### Summary

Weather by country name query parameters.

<a name='P-Simply-DomainModel-CountriesQueryParameters-Country'></a>
### Country `property`

##### Summary

Gets or sets the name.

<a name='P-Simply-DomainModel-CountriesQueryParameters-State'></a>
### State `property`

##### Summary

Gets or sets the name.

<a name='T-Simply-DomainModel-CountryDto'></a>
## CountryDto `type`

##### Namespace

Simply.DomainModel

##### Summary

Country data transfer object.

<a name='P-Simply-DomainModel-CountryDto-Cities'></a>
### Cities `property`

##### Summary

Gets or sets the cities.

<a name='P-Simply-DomainModel-CountryDto-Name'></a>
### Name `property`

##### Summary

Gets or sets the country name.

<a name='P-Simply-DomainModel-CountryDto-States'></a>
### States `property`

##### Summary

Gets or sets the states.

<a name='P-Simply-DomainModel-CountryDto-ThreeLetterCode'></a>
### ThreeLetterCode `property`

##### Summary

Gets or sets the three letter code.

<a name='T-Simply-DomainModel-GetCityInput'></a>
## GetCityInput `type`

##### Namespace

Simply.DomainModel

##### Summary

Get city input.

<a name='P-Simply-DomainModel-GetCityInput-Name'></a>
### Name `property`

##### Summary

Gets or sets the city name.

<a name='T-Simply-DomainModel-GetCountriesInput'></a>
## GetCountriesInput `type`

##### Namespace

Simply.DomainModel

##### Summary

Get weather by country name input.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Country | [T:Simply.DomainModel.GetCountriesInput](#T-T-Simply-DomainModel-GetCountriesInput 'T:Simply.DomainModel.GetCountriesInput') | Country name. |

<a name='M-Simply-DomainModel-GetCountriesInput-#ctor-System-String,System-String-'></a>
### #ctor(Country,State) `constructor`

##### Summary

Get weather by country name input.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Country | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Country name. |
| State | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | State name. |

<a name='P-Simply-DomainModel-GetCountriesInput-Country'></a>
### Country `property`

##### Summary

Country name.

<a name='P-Simply-DomainModel-GetCountriesInput-State'></a>
### State `property`

##### Summary

State name.

<a name='T-Simply-DomainModel-StateDto'></a>
## StateDto `type`

##### Namespace

Simply.DomainModel

##### Summary

State data transfer object.

<a name='P-Simply-DomainModel-StateDto-Name'></a>
### Name `property`

##### Summary

Gets or sets the country name.

<a name='P-Simply-DomainModel-StateDto-StateCode'></a>
### StateCode `property`

##### Summary

Gets or sets the country name.
