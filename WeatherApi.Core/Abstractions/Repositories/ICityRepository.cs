using System.Linq;
using WeatherApi.Core.Entities;

namespace WeatherApi.Core.Abstractions.Repositories
{
    public interface ICityRepository : IRepository<City>
    {
        IQueryable<City> GetByName(string name);
    }
}
