namespace Simply.ServiceAgent.WeatherService.Agent;

public class WeatherServiceAgent
{
    private const string BaseUrl = "http://api.weatherapi.com/v1";
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
    
    //"

    public async Task<GetWeatherForCityOutput> GetWeatherForCity(GetWeatherForCityInput input)
    {
        try
        {
            this.logger.LogInformation("Get country's rate @{input}", input);

            GetWeatherForCityOutput output = new();

            string url = $"{BaseUrl}/current.json?key=6eca85b1d048484c966181029242003&q={cityName}&api=no";

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
}