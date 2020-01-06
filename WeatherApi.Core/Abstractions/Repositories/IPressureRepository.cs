using WeatherApi.Core.Entities;

namespace WeatherApi.Core.Abstractions.Repositories
{
    public interface IPressureRepository : IRepository<Pressure>
    {
        public void RemoveAll();
    }
}
