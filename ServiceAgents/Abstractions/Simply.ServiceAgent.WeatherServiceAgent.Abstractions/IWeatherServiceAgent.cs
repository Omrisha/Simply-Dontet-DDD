namespace Simply.ServiceAgent.WeatherServiceAgent.Abstractions;

using System.Threading.Tasks;

public interface IWeatherServiceAgent
{
    Task<GetWeatherForCityOutput> GetWeatherForCity(GetWeatherForCityInput input);
}