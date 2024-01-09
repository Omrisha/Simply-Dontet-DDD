<a name='assembly'></a>
# Simply.Core

## Contents

- [EntityNotFoundException](#T-Simply-Core-EntityNotFoundException 'Simply.Core.EntityNotFoundException')
- [ServerErrorException](#T-Simply-Core-ServerErrorException 'Simply.Core.ServerErrorException')
  - [#ctor(message)](#M-Simply-Core-ServerErrorException-#ctor-System-String- 'Simply.Core.ServerErrorException.#ctor(System.String)')
- [WebApiOptions](#T-Simply-Core-WebApiOptions 'Simply.Core.WebApiOptions')
  - [AllowedOrigins](#P-Simply-Core-WebApiOptions-AllowedOrigins 'Simply.Core.WebApiOptions.AllowedOrigins')

<a name='T-Simply-Core-EntityNotFoundException'></a>
## EntityNotFoundException `type`

##### Namespace

Simply.Core

##### Summary

Entity not found exception.

<a name='T-Simply-Core-ServerErrorException'></a>
## ServerErrorException `type`

##### Namespace

Simply.Core

##### Summary

Server error exception.

<a name='M-Simply-Core-ServerErrorException-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

Initializes a new instance of the [ServerErrorException](#T-Simply-Core-ServerErrorException 'Simply.Core.ServerErrorException') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | An error message. |

<a name='T-Simply-Core-WebApiOptions'></a>
## WebApiOptions `type`

##### Namespace

Simply.Core

##### Summary

Web API options.

<a name='P-Simply-Core-WebApiOptions-AllowedOrigins'></a>
### AllowedOrigins `property`

##### Summary

Gets or sets an array of allowed origins by domain.
