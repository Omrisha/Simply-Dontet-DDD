namespace Simply.DomainModel.Impl;

using System;
using System.Net.Http;
using System.Text.Json;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Simply.Core;
using Simply.DomainModel.Cqrs;
using Simply.ServiceAgent.CountriesServiceAgent.Abstractions;
using Simply.ServiceAgent.WeatherServiceAgent.Abstractions;

/// <summary>
/// Weather reader.
/// </summary>
public class WeatherReader :
    IRequestHandler<GetWeatherByCityNameQuery, WeatherDto>,
    IRequestHandler<GetWeatherByLocationQuery, WeatherByLocationDto>
{
    private const string BaseUrl = "https://countriesnow.space/api/v0.1";
    private readonly ILogger<WeatherReader> logger;
    private readonly IMapper mapper;
    private readonly IWeatherServiceAgent weatherServiceAgent;

    /// <summary>
    /// Initializes a new instance of the <see cref="WeatherReader"/> class.
    /// </summary>
    /// <param name="logger">A <see cref="ILogger{CountryReader}"/> instnace.</param>
    /// <param name="mapper">A <see cref="IMapper"/> instance.</param>
    /// <param name="weatherServiceAgent">A <see cref="IWeatherServiceAgent"/> instance.</param>
    public WeatherReader(ILogger<WeatherReader> logger, IMapper mapper, IWeatherServiceAgent weatherServiceAgent)
    {
        this.logger = logger;
        this.mapper = mapper;
        this.weatherServiceAgent = weatherServiceAgent;
    }

    /// <summary>
    /// Get wather query logic by city name.
    /// </summary>
    /// <param name="input">A <see cref="GetCountriesInput"/> instnace.</param>
    /// <returns>A task containing <see cref="IQueryable{CountryDto}"/> instnace.</returns>
    public async Task<WeatherByLocationDto> GetWeatherByLocation(GetWeathByLocationInput input)
    {
        try
        {
            this.logger.LogInformation("Get wather query logic by city name @{input}", input);

            WeatherByLocationDto result = new();

            GetWeatherForLocationInput serviceAgentInput = this.mapper.Map<GetWeathByLocationInput, GetWeatherForLocationInput>(input);

            GetWeatherForLocationOutput output = await this.weatherServiceAgent.GetWeatherForLocation(serviceAgentInput);

            result = this.mapper.Map<GetWeatherForLocationOutput, WeatherByLocationDto>(output);

            return result;
        }
        catch (Exception ex)
        {
            this.logger.LogError(ex, "{Message}", ex.Message);
            throw;
        }
    }

    /// <summary>
    /// Get wather query logic by city name.
    /// </summary>
    /// <param name="input">A <see cref="GetCountriesInput"/> instnace.</param>
    /// <returns>A task containing <see cref="IQueryable{CountryDto}"/> instnace.</returns>
    public async Task<WeatherDto> GetWeatherByCity(GetWeatherByCityInput input)
    {
        try
        {
            this.logger.LogInformation("Get wather query logic by city name @{input}", input);

            WeatherDto result = new();

            GetWeatherForCityInput serviceAgentInput = this.mapper.Map<GetWeatherByCityInput, GetWeatherForCityInput>(input);

            GetWeatherForCityOutput output = await this.weatherServiceAgent.GetWeatherForCity(serviceAgentInput);

            result = this.mapper.Map<GetWeatherForCityOutput, WeatherDto>(output);

            return result;
        }
        catch (Exception ex)
        {
            this.logger.LogError(ex, "{Message}", ex.Message);
            throw;
        }
    }

    /// <inheritdoc/>
    public async Task<WeatherDto> Handle(GetWeatherByCityNameQuery request, CancellationToken cancellationToken)
    {
        return await this.GetWeatherByCity(request.Input);
    }

    /// <inheritdoc/>
    public async Task<WeatherByLocationDto> Handle(GetWeatherByLocationQuery request, CancellationToken cancellationToken)
    {
        return await this.GetWeatherByLocation(request.Input);
    }
}