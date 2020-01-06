using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WeatherApi.Core.Abstractions.Services;
using WeatherApi.Core.Entities;

namespace WeatherApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PressureController : ControllerBase
    {
        private readonly IPressureService _pressureService;

        public PressureController(IPressureService pressureService)
        {
            _pressureService = pressureService;
        }

        [HttpGet]
        public ActionResult<List<Pressure>> GetAll()
        {
            var result = _pressureService.GetAll();

            return result;
        }

        [HttpPost]
        public IActionResult Post(List<Pressure> pressures)
        {
            _pressureService.Insert(pressures);

            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            _pressureService.Delete();

            return NoContent();
        }
    }
}
