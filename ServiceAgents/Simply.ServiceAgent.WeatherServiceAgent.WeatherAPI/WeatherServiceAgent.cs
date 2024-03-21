namespace Simply.ServiceAgent.WeatherService.Agent;

using Microsoft.Extensions.Logging;
using Simply.Core;
using Simply.ServiceAgent.WeatherServiceAgent.Abstractions;
using System.Net.Http;
using System.Text.Json;

public class WeatherServiceAgent : IWeatherServiceAgent
{
    private const string BaseUrl = "https://api.weatherapi.com/v1";
    private readonly ILogger<WeatherServiceAgent> logger;
    private HttpClient httpClient;

    /// <summary>
    /// Initializes a new instance of the <see cref="CountriesServiceAgent"/> class.
    /// </summary>
    /// <param name="logger">A <see cref="ILogger{CountriesServiceAgent}"/> instnace.</param>
    /// <param name="httpClientFactory">A <see cref="IHttpClientFactory"/> instance.</param>
    public WeatherServiceAgent(ILogger<WeatherServiceAgent> logger, IHttpClientFactory httpClientFactory)
    {
        this.logger = logger;
        this.httpClient = httpClientFactory.CreateClient("CountryClient");
    }

    public async Task<GetWeatherForCityOutput> GetWeatherForCity(GetWeatherForCityInput input)
    {
        try
        {
            this.logger.LogInformation("Get country's rate @{input}", input);

            if (string.IsNullOrEmpty(input.CityName))
            {
                throw new ArgumentNullException(nameof(input.CityName));
            }

            GetWeatherForCityOutput output = new();

            string url = $"{BaseUrl}/forecast.json?q={input.CityName}&days=7&key=6eca85b1d048484c966181029242003%20";

            HttpResponseMessage httpResponseMessage;

            httpResponseMessage = await this.httpClient.GetAsync(url);

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                string responseJson = await httpResponseMessage.Content.ReadAsStringAsync();
                output = JsonSerializer.Deserialize<GetWeatherForCityOutput>(responseJson);

                if (output is null)
                {
                    throw new FetchDataException("Probelm with data from weather API");
                }

            }
            else
            {
                throw new FetchDataException("There's was unexpected error with the service.");
            }

            return output;
        }
        catch (Exception ex)
        {
            this.logger.LogError(ex, "{Message}", ex.Message);
            throw;
        }
    }
}