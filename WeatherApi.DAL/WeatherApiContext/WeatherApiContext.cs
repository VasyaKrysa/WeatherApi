using Microsoft.EntityFrameworkCore;
using WeatherApi.Core.Entities;

namespace WeatherApi.DAL
{
    public class WeatherApiContext: DbContext
    {
        public DbSet<City> Cities { get; set; }
       

        public WeatherApiContext(DbContextOptions<WeatherApiContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
        }
    }
}

