using System;

namespace WeatherApi.Core.Entities
{
    public class Temperature : IEntity<int>
    {
        public int Id { get; set; }
        
        public int CityId { get; set; }
        
        public City City { get; set; }
        
        public DateTime Date { get; set; }
        
        public double Value { get; set; }
    }
}
