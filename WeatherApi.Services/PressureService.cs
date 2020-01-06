using System.Collections.Generic;
using WeatherApi.Core.Entities;
using WeatherApi.Core.Abstractions.Services;
using WeatherApi.Core.Abstractions;
using System.Linq;

namespace WeatherApi.Services
{
    public class PressureService : IPressureService
    {
        private IUnitOfWork unitOfWork;
       
        public PressureService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        
        public void Delete()
        {
            unitOfWork.PressureRepository.RemoveAll();
            unitOfWork.Save();
        }

        public List<Pressure> GetAll()
        {
            var result = unitOfWork.PressureRepository.List().ToList();
            unitOfWork.Save();

            return result;
        }

        public void Insert(List<Pressure> entities)
        {
            unitOfWork.PressureRepository.AddRange(entities);
            unitOfWork.Save();
        }
    }
}
