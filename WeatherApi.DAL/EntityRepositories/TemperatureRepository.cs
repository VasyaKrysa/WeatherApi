using WeatherApi.Core.Abstractions.Repositories;
using WeatherApi.Core.Entities;

namespace WeatherApi.DAL.EntityRepositories
{
    public class TemperatureRepository : BaseRepository<Temperature>, ITemperatureRepository
    {
        public TemperatureRepository(WeatherApiContext _context) : base(_context)
        {
        }
    }
}
