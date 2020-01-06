using System.Text.Json;
using System.Threading.Tasks;

namespace WeatherApi.Core.Abstractions.Services
{
    public interface IOpenWeatherService
    {
        Task<JsonDocument> GetCurentWeather(string name);

        Task<JsonDocument> GetWeatherFor5Day(int id);
    }
}
