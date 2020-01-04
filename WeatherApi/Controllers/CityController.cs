using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WeatherApi.Core.Abstractions.Services;
using WeatherApi.Core.Entities;

namespace WeatherApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet]
        public ActionResult<List<City>> GetAll()
        {
            var result = _cityService.GetAll();

            return result;
        }

        //[HttpGet("{id}")]
        //public ActionResult<City> GetById(int id)
        //{
        //    var result = _cityService.GetById(id);

        //    return result;
        //}
        [HttpGet("{name}")]
        public ActionResult<List<City>> GetByName(string name)
        {
            var result = _cityService.GetByName(name);

            return result;
        }

        [HttpPost]
        public ActionResult<City> Post(City city)
        {
            var result = _cityService.Insert(city);

            return result;
        }

        [HttpPut]
        public IActionResult Put(City city)
        {
            _cityService.Update(city);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _cityService.Delete(id);

            return NoContent();
        }
    }
}
