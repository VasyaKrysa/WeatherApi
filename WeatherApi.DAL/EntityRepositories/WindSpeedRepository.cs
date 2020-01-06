using WeatherApi.Core.Abstractions.Repositories;
using WeatherApi.Core.Entities;

namespace WeatherApi.DAL.EntityRepositories
{
    class WindSpeedRepository : BaseRepository<WindSpeed>, IWindSpeedRepository
    {
        public WindSpeedRepository(WeatherApiContext _context) : base(_context)
        {
        }
    }
}
