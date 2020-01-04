using System;
using WeatherApi.Core.Abstractions.Repositories;

namespace WeatherApi.Core.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        ICityRepository CityRepository { get; }
        void Save();
    }
}
