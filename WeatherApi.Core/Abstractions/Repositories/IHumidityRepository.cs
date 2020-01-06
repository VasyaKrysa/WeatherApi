using WeatherApi.Core.Entities;

namespace WeatherApi.Core.Abstractions.Repositories
{
    public interface IHumidityRepository:IRepository<Humidity>
    {
        public void RemoveAll();
    }
}
