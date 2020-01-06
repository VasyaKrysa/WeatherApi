using WeatherApi.Core.Abstractions.Repositories;
using WeatherApi.Core.Entities;

namespace WeatherApi.DAL.EntityRepositories
{
    class HumidityRepository : BaseRepository<Humidity>, IHumidityRepository
    {
        public HumidityRepository(WeatherApiContext _context) : base(_context)
        {
        }
    }
}
