using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WeatherApi.Core.Abstractions.Services;
using WeatherApi.Core.Entities;

namespace WeatherApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HumidityController : ControllerBase
    {
        private readonly IHumidityService _humidityService;

        public HumidityController(IHumidityService humidityService)
        {
            _humidityService = humidityService;
        }

        [HttpGet]
        public ActionResult<List<Humidity>> GetAll()
        {
            var result = _humidityService.GetAll();

            return result;
        }

        [HttpPost]
        public IActionResult Post(List<Humidity> humidities)
        {
            _humidityService.Insert(humidities);

            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            _humidityService.Delete();

            return NoContent();
        }
    }
}
