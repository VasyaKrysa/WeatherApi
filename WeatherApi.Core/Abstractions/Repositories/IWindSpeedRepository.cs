using WeatherApi.Core.Entities;

namespace WeatherApi.Core.Abstractions.Repositories
{
    public interface IWindSpeedRepository : IRepository<WindSpeed>
    {
        public void RemoveAll();
    }
}
