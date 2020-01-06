using Microsoft.EntityFrameworkCore;
using WeatherApi.Core.Entities;

namespace WeatherApi.DAL
{
    public class WeatherApiContext: DbContext
    {
        public DbSet<City> Cities { get; set; }
        
        public DbSet<Temperature> Temperature { get; set; }
        
        public DbSet<Pressure> Pressure { get; set; }
        
        public DbSet<Humidity> Humidity { get; set; }
        
        public DbSet<WindSpeed> WindSpeed { get; set; }
               
        public WeatherApiContext(DbContextOptions<WeatherApiContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Temperature>(entity =>
            {
                entity.HasOne(e => e.City)
                .WithMany(e => e.Temperatures)
                .HasForeignKey(e => e.CityId);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Pressure>(entity =>
            {
                entity.HasOne(e => e.City)
                .WithMany(e => e.Pressures)
                .HasForeignKey(e => e.CityId);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Humidity>(entity =>
            {
                entity.HasOne(e => e.City)
                .WithMany(e => e.Humidities)
                .HasForeignKey(e => e.CityId);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WindSpeed>(entity =>
            {
                entity.HasOne(e => e.City)
                .WithMany(e => e.WindSpeeds)
                .HasForeignKey(e => e.CityId);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });
        }
    }
}
