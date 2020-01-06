using System.Collections.Generic;

namespace WeatherApi.Core.Entities
{
    public class City : IEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Temperature> Temperatures { get; set; }
        
        public List<Pressure> Pressures { get; set; }
        
        public List<Humidity> Humidities { get; set; }
        
        public List<WindSpeed> WindSpeeds { get; set; }
    }
}
