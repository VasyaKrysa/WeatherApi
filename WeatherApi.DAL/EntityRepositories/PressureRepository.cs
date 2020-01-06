using WeatherApi.Core.Abstractions.Repositories;
using WeatherApi.Core.Entities;

namespace WeatherApi.DAL.EntityRepositories
{
    class PressureRepository : BaseRepository<Pressure>, IPressureRepository
    {
        public PressureRepository(WeatherApiContext _context) : base(_context)
        {
        }
    }
}
