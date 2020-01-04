using WeatherApi.Core.Abstractions;
using WeatherApi.Core.Abstractions.Repositories;
using WeatherApi.DAL.EntityRepositories;

namespace WeatherApi.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ICityRepository _cityRepository;
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
