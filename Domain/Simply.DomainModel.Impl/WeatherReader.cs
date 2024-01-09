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

/// <summary>
/// Weather reader.
/// </summary>
public class WeatherReader :
    IRequestHandler<GetWeatherByCountryNameQuery, ICollection<CountryDto>>
{
    private const string BaseUrl = "https://countriesnow.space/api/v0.1";
    private readonly ILogger<WeatherReader> logger;
    private readonly IMapper mapper;
    private readonly ICountriesSeviceAgent countriesSeviceAgent;

    /// <summary>
    /// Initializes a new instance of the <see cref="WeatherReader"/> class.
    /// </summary>
    /// <param name="logger">A <see cref="ILogger{CountryReader}"/> instnace.</param>
    /// <param name="mapper">A <see cref="IMapper"/> instance.</param>
    /// <param name="countriesSeviceAgent">A <see cref="ICountriesSeviceAgent"/> instance.</param>
    public WeatherReader(ILogger<WeatherReader> logger, IMapper mapper, ICountriesSeviceAgent countriesSeviceAgent)
    {
        this.logger = logger;
        this.mapper = mapper;
        this.countriesSeviceAgent = countriesSeviceAgent;
    }

    /// <summary>
    /// Get countries logic.
    /// </summary>
    /// <param name="input">A <see cref="GetCountriesInput"/> instnace.</param>
    /// <returns>A task containing <see cref="IQueryable{CountryDto}"/> instnace.</returns>
    public async Task<ICollection<CountryDto>> GetCountries(GetCountriesInput input)
    {
        try
        {
            this.logger.LogInformation("Get countries query logic by @{input}", input);

            List<CountryDto> result = new();

            GetCountriesWithStatesInput getCountriesWithStatesInput = this.mapper.Map<GetCountriesInput, GetCountriesWithStatesInput>(input);
            GetCountriesWithCitiesInput getCountriesWithCitiesInput = this.mapper.Map<GetCountriesInput, GetCountriesWithCitiesInput>(input);

            GetCountriesWithStatesOutput getCountriesWithStatesOutput = await this.countriesSeviceAgent.GetCountriesWithStatesByFilter(getCountriesWithStatesInput);
            GetCountriesWithCitiesOutput getCountriesWithCitiesOutput = await this.countriesSeviceAgent.GetCountriesWithCitiesByFilter(getCountriesWithCitiesInput);

            Dictionary<string, List<string>> countryToCityMapping = getCountriesWithCitiesOutput.Data.DistinctBy(k => k.Name).ToDictionary(k => k.Name, v => v.Cities);

            getCountriesWithStatesOutput.Data.ForEach(c =>
            {
                List<string> cities = new();
                countryToCityMapping.TryGetValue(c.Name, out cities);
                result.Add(new CountryDto
                {
                    Name = c.Name,
                    ThreeLetterCode = c.ThreeLetterCode,
                    States = this.mapper.Map<List<StateDataModel>, List<StateDto>>(c.States),
                    Cities = cities,
                });
            });

            return result;
        }
        catch (Exception ex)
        {
            this.logger.LogError(ex, "{Message}", ex.Message);
            throw;
        }
    }

    /// <inheritdoc/>
    public async Task<ICollection<CountryDto>> Handle(GetWeatherByCountryNameQuery request, CancellationToken cancellationToken)
    {
        return await this.GetCountries(request.GetCountriesInput);
    }
}