using System;
using WeatherApi.Core.Abstractions.Repositories;

namespace WeatherApi.Core.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        ICityRepository CityRepository { get; }

        public ITemperatureRepository TemperatureRepository { get; }
        
        public IPressureRepository PressureRepository { get; }
        
        public IHumidityRepository HumidityRepository { get; }
        
        public IWindSpeedRepository WindSpeedRepository { get; }
        
        void Save();
    }
}
