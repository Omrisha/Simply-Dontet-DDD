namespace Simply.DomainModel.Impl;

using System;
using System.Net.Http;
using System.Text.Json;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Simply.Core;
using Simply.DomainModel.Cqrs;

/// <summary>
/// Weather reader.
/// </summary>
public class WeatherReader :
    IRequestHandler<GetWeatherByCountryNameQuery, ICollection<CountryDto>>
{
    private const string BaseUrl = "https://api.weatherbit.io/v2.0/current?key=e65ef8948538477fabe19b9ac4e7d029";
    private readonly ILogger<WeatherReader> logger;
    private readonly IMapper mapper;
    private HttpClient httpClient;

    /// <summary>
    /// Initializes a new instance of the <see cref="WeatherReader"/> class.
    /// </summary>
    /// <param name="logger">A <see cref="ILogger{CountryReader}"/> instnace.</param>
    /// <param name="mapper">A <see cref="IMapper"/> instance.</param>
    /// <param name="httpClientFactory">A <see cref="IHttpClientFactory"/> instance.</param>
    public WeatherReader(ILogger<WeatherReader> logger, IMapper mapper, IHttpClientFactory httpClientFactory)
    {
        this.logger = logger;
        this.mapper = mapper;
        this.httpClient = httpClientFactory.CreateClient("CountryClient");
    }

    /// <summary>
    /// Get countries logic.
    /// </summary>
    /// <param name="getCountriesInput">A <see cref="GetWeatherByCountryNameInput"/> instnace.</param>
    /// <returns>A task containing <see cref="IQueryable{CountryDto}"/> instnace.</returns>
    public async Task<ICollection<CountryDto>> GetCountries(GetWeatherByCountryNameInput getCountriesInput)
    {
        try
        {
            this.logger.LogInformation("Get countries query logic by {Name}", getCountriesInput.Name);

            string url = $"{BaseUrl}?city={getCountriesInput.Name}";

            HttpResponseMessage httpResponseMessage = await this.httpClient.GetAsync(url);

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                string json = await httpResponseMessage.Content.ReadAsStringAsync();
                List<CountryDto>? countries = JsonSerializer.Deserialize<List<CountryDto>>(json);

                if (countries is null)
                {
                    throw new EntityNotFoundException(nameof(CountryDto), getCountriesInput.Name);
                }

                return countries;
            }
            else
            {
                throw new ServerErrorException("There's was unexpected error with the service.");
            }
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