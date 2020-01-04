using System.Collections.Generic;
using WeatherApi.Core.Entities;

namespace WeatherApi.Core.Abstractions.Services
{
    public interface ICityService
    {
        public List<City> GetAll();
        public List<City> GetByName(string Name);
        public City GetById(int id);
        public City Insert(City city);
        public void Update(City city);
        public void Delete(int cityId);
    }
}
