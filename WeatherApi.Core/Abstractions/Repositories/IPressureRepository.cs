using System.Collections.Generic;
using WeatherApi.Core.Entities;

namespace WeatherApi.Core.Abstractions.Repositories
{
    public interface IPressureRepository : IRepository<Pressure>
    {
        public void RemoveAll();

        public void AddRange(IEnumerable<Pressure> entity);
    }
}
