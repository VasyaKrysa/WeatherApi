using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WeatherApi.Core.Abstractions.Services;
using WeatherApi.Core.Entities;

namespace WeatherApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemperatureController : ControllerBase
    {
        private readonly ITemperatureService _temperatureService;

        public TemperatureController(ITemperatureService temperatureService)
        {
            _temperatureService = temperatureService;
        }

        [HttpGet]
        public ActionResult<List<Temperature>> GetAll()
        {
            var result = _temperatureService.GetAll();

            return result;
        }

        [HttpPost]
        public IActionResult Post(List<Temperature> temperatures)
        {
            _temperatureService.Insert(temperatures);

            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            _temperatureService.Delete();

            return NoContent();
        }
    }
}
