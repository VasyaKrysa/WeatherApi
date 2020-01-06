using System.Collections.Generic;
using WeatherApi.Core.Entities;

namespace WeatherApi.Core.Abstractions.Repositories
{
    public interface IWindSpeedRepository : IRepository<WindSpeed>
    {
        public void RemoveAll();

        public void AddRange(IEnumerable<WindSpeed> entity);
    }
}
