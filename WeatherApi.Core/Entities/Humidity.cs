using System;

namespace WeatherApi.Core.Entities
{
    public class Humidity : IEntity<int>
    {
        public int Id { get; set; }
      
        public int CityId { get; set; }
        
        public City City { get; set; }
        
        public string Date { get; set; }
        
        public int Value { get; set; }
    }
}
