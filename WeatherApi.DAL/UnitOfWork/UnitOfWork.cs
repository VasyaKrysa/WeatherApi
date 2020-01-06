using WeatherApi.Core.Abstractions;
using WeatherApi.Core.Abstractions.Repositories;
using WeatherApi.DAL.EntityRepositories;

namespace WeatherApi.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ICityRepository _cityRepository;

        private ITemperatureRepository _temperatureRepository;
        
        private IHumidityRepository _humidityRepository;
        
        private IPressureRepository _pressureRepository;
        
        private IWindSpeedRepository _windSpeedRepository;
        
        private WeatherApiContext _context;
        
        public UnitOfWork(WeatherApiContext context)
        {
            _context = context;

        }
        
        public ICityRepository CityRepository
        {
            get
            {
                return _cityRepository ??= new CityRepository(_context);
            }
        }
        
        public ITemperatureRepository TemperatureRepository
        {
            get
            {
                return _temperatureRepository ??= new TemperatureRepository(_context);
            }
        }
        
        public IPressureRepository PressureRepository
        {
            get
            {
                return _pressureRepository ??= new PressureRepository(_context);
            }
        }
        
        public IHumidityRepository HumidityRepository
        {
            get
            {
                return _humidityRepository ??= new HumidityRepository(_context);
            }
        }
        
        public IWindSpeedRepository WindSpeedRepository
        {
            get
            {
                return _windSpeedRepository ??= new WindSpeedRepository(_context);
            }
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
                _context = null;
            }
        }
        
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
