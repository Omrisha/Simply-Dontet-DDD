namespace Simply.ServiceAgent.CountriesServiceAgent.CountriesNow;

using Microsoft.Extensions.Logging;
using Simply.ServiceAgent.CountriesServiceAgent.Abstractions;
using System.Net.Http;
using System.Text.Json;

public class CountriesServiceAgent : ICountriesSeviceAgent
{
    private const string BaseUrl = "https://countriesnow.space/api/v0.1";
    private readonly ILogger<CountriesServiceAgent> logger;
    private HttpClient httpClient;

    /// <summary>
    /// Initializes a new instance of the <see cref="CountriesServiceAgent"/> class.
    /// </summary>
    /// <param name="logger">A <see cref="ILogger{CountriesServiceAgent}"/> instnace.</param>
    /// <param name="httpClientFactory">A <see cref="IHttpClientFactory"/> instance.</param>
    public CountriesServiceAgent(ILogger<CountriesServiceAgent> logger, IHttpClientFactory httpClientFactory)
    {
        this.logger = logger;
        this.httpClient = httpClientFactory.CreateClient("CountryClient");
    }

    public async Task<GetRateByCountryFilterOutput> GetRateByCountryFilter(GetRateByCountryFilterInput input)
    {
        try
        {
            this.logger.LogInformation("Get country's rate @{input}", input);

            GetRateByCountryFilterOutput output = new();

            string url = $"{BaseUrl}/countries/currency";

            HttpResponseMessage httpResponseMessage;

            if (string.IsNullOrEmpty(input.TwoLetterCode))
            {
                httpResponseMessage = await this.httpClient.GetAsync(url);
            }
            else
            {
                string json = JsonSerializer.Serialize(input);
                StringContent content = new(json);
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                httpResponseMessage = await this.httpClient.PostAsync(url, content);
            }

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                string responseJson = await httpResponseMessage.Content.ReadAsStringAsync();
                output = JsonSerializer.Deserialize<GetRateByCountryFilterOutput>(responseJson);

                if (output is null)
                {
                    throw new FetchDataException("Probelm with data from countries API");
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

    public async Task<GetCountriesWithStatesOutput> GetCountriesWithStatesByFilter(GetCountriesWithStatesInput input)
    {
        try
        {
            this.logger.LogInformation("Get countries query logic by @{input}", input);

            GetCountriesWithStatesOutput output = new();

            string url = $"{BaseUrl}/countries/states";

            HttpResponseMessage httpResponseMessage;

            if (string.IsNullOrEmpty(input.Country))
            {
                httpResponseMessage = await this.httpClient.GetAsync(url);
            }
            else
            {
                string json = JsonSerializer.Serialize(input);
                StringContent content = new(json);
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                httpResponseMessage = await this.httpClient.PostAsync(url, content);
            }

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                string responseJson = await httpResponseMessage.Content.ReadAsStringAsync();
                output = JsonSerializer.Deserialize<GetCountriesWithStatesOutput>(responseJson);

                if (output is null)
                {
                    throw new FetchDataException("Probelm with data from countries API");
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

    public async Task<GetCountriesWithCitiesOutput> GetCountriesWithCitiesByFilter(GetCountriesWithCitiesInput input)
    {
        try
        {
            this.logger.LogInformation("Get countries query logic by @{input}", input);

            GetCountriesWithCitiesOutput output = new();

            string url = $"{BaseUrl}/countries";

            HttpResponseMessage httpResponseMessage = await this.httpClient.GetAsync(url);

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                string responseJson = await httpResponseMessage.Content.ReadAsStringAsync();
                output = JsonSerializer.Deserialize<GetCountriesWithCitiesOutput>(responseJson);

                if (output is null)
                {
                    throw new FetchDataException("Probelm with data from countries API");
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
