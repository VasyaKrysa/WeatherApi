using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeatherApi.Core.Abstractions.Services;
using System.Net.Http;
using System.Text.Json;

namespace WeatherApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly IOpenWeatherService _weatherService;

        public WeatherController(IOpenWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<JsonDocument>> GetByName(string name)
        {
            try
            {
                var result = await _weatherService.GetCurentWeather(name);

                return result;
            }
            catch(HttpRequestException)
            { 
                return NotFound();
            }
        }

        [HttpGet]
        public async Task<ActionResult<JsonDocument>> GetById([FromQuery]int id)
        {
            try
            {
                var result = await _weatherService.GetWeatherFor5Day(id);

                return result;
            }
            catch (HttpRequestException)
            {
                return NotFound();
            }
        }
    }
}
