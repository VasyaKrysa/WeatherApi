using System.Collections.Generic;
using WeatherApi.Core.Entities;
using WeatherApi.Core.Abstractions.Services;
using WeatherApi.Core.Abstractions;
using System.Linq;

namespace WeatherApi.Services
{
    public class HumidityService : IHumidityService
    {
        private IUnitOfWork unitOfWork;
       
        public HumidityService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        
        public void Delete()
        {
            unitOfWork.HumidityRepository.RemoveAll();
            unitOfWork.Save();
        }

        public List<Humidity> GetAll()
        {
            var result = unitOfWork.HumidityRepository.List().ToList();
            unitOfWork.HumidityRepository.RemoveAll();
            unitOfWork.Save();

            return result;
        }

        public void Insert(List<Humidity> entities)
        {
           foreach(var entity in entities)
            {
                unitOfWork.HumidityRepository.Add(entity);
            }
            unitOfWork.Save();
        }
    }
}
