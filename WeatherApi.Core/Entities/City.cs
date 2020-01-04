namespace WeatherApi.Core.Entities
{
    public class City : IEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
