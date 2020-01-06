using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using WeatherApi.Core.Abstractions.Repositories;
using WeatherApi.Core.Entities;

namespace WeatherApi.DAL
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity<int>
    {
        private readonly WeatherApiContext _context;

        public BaseRepository(WeatherApiContext context)
        {
            _context = context;
        }

        public virtual TEntity Add(TEntity entity)
        {
            var includeEntity = _context.Set<TEntity>().Find(entity.Id);
            if (includeEntity == null)
                _context.Set<TEntity>().Add(entity);
            else throw new ArgumentException("This value already in the database");

            return entity;
        }

        public virtual void Delete(int id)
        {
            var entity = _context.Set<TEntity>().Find(id);
            if (entity != null)
                _context.Set<TEntity>().Remove(entity);
            else
                throw new Exception("Not found");
        }
        public virtual void RemoveAll()
        {
            _context.Set<TEntity>().RemoveRange(_context.Set<TEntity>());
        }

        public virtual void Edit(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public virtual TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public virtual IQueryable<TEntity> List()
        {
            return _context.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> List(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>()
              .Where(predicate);
        }
    }
}
