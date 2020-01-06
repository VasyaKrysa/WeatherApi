using System.Collections.Generic;
using WeatherApi.Core.Entities;

namespace WeatherApi.Core.Abstractions.Services
{
    public interface IMetricsService<TEntity> where TEntity : class, IEntity<int>
    {
        public List<TEntity> GetAll();

        public void Insert(List<TEntity> entities);
        
        public void Delete();
    }
}
