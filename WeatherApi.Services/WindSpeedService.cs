using System.Collections.Generic;
using WeatherApi.Core.Entities;
using WeatherApi.Core.Abstractions.Services;
using WeatherApi.Core.Abstractions;
using System.Linq;

namespace WeatherApi.Services
{
    public class WindSpeedService : IWindSpeedService
    {
        private IUnitOfWork unitOfWork;
        public WindSpeedService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public void Delete()
        {
            unitOfWork.WindSpeedRepository.RemoveAll();
            unitOfWork.Save();
        }

        public List<WindSpeed> GetAll()
        {
            var result = unitOfWork.WindSpeedRepository.List().ToList();
            unitOfWork.WindSpeedRepository.RemoveAll();
            unitOfWork.Save();

            return result;
        }

        public void Insert(List<WindSpeed> entities)
        {
           foreach(var entity in entities)
            {
                unitOfWork.WindSpeedRepository.Add(entity);
            }
            unitOfWork.Save();
        }
    }
}
