using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using WeatherApi.Core.Abstractions;
using WeatherApi.Core.Abstractions.Services;
using WeatherApi.Core.Entities;

namespace WeatherApi.Services
{
    public class CityService: ICityService
    {
        private IUnitOfWork unitOfWork;
        public CityService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public List<City> GetAll()
        {
            return unitOfWork.CityRepository.List().ToList();
        }

        public City GetById(int id)
        {
            var item = unitOfWork.CityRepository.GetById(id);
            if (item == null)
                throw new Exception("Not found");

            return item;
        }

        public City Insert(City item)
        {
            var city = unitOfWork.CityRepository.Add(item);
            unitOfWork.Save();

            return city;
        }

        public void Update(City city)
        {
            unitOfWork.CityRepository.Edit(city);
            unitOfWork.Save();
        }

        public void Delete(int cityId)
        {
            unitOfWork.CityRepository.Delete(cityId);
            unitOfWork.Save();
        }

        public List<City> GetByName(string name)
        {
           return unitOfWork.CityRepository.GetByName(name).ToList();
        }
    }
}
