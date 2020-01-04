using Microsoft.EntityFrameworkCore;
using System.Linq;
using WeatherApi.Core.Abstractions.Repositories;
using WeatherApi.Core.Entities;

namespace WeatherApi.DAL.EntityRepositories
{
    class CityRepository : BaseRepository<City>, ICityRepository
    {
        public CityRepository(WeatherApiContext _context) : base(_context)
        {
        }

        public IQueryable<City> GetByName(string name)
        {
            return List().Where(city => EF.Functions.Like(city.Name, "%"+name+"%"));
        }
    }
}

