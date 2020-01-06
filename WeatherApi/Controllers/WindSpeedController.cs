using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WeatherApi.Core.Abstractions.Services;
using WeatherApi.Core.Entities;

namespace WeatherApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WindSpeedController : ControllerBase
    {
        private readonly IWindSpeedService _windSpeedService;

        public WindSpeedController(IWindSpeedService windSpeedService)
        {
            _windSpeedService = windSpeedService;
        }

        [HttpGet]
        public ActionResult<List<WindSpeed>> GetAll()
        {
            var result = _windSpeedService.GetAll();

            return result;
        }

        [HttpPost]
        public IActionResult Post(List<WindSpeed> windSpeeds)
        {
            _windSpeedService.Insert(windSpeeds);

            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            _windSpeedService.Delete();

            return NoContent();
        }
    }
}
