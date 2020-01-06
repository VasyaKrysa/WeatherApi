using WeatherApi.Core.Entities;

namespace WeatherApi.Core.Abstractions.Repositories
{
    public interface ITemperatureRepository : IRepository<Temperature>
    {
        public void RemoveAll();
    }
}
