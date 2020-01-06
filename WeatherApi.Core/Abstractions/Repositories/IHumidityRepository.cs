using System.Collections.Generic;
using WeatherApi.Core.Entities;

namespace WeatherApi.Core.Abstractions.Repositories
{
    public interface IHumidityRepository:IRepository<Humidity>
    {
        public void RemoveAll();

        public void AddRange(IEnumerable<Humidity> entity);

    }
}
