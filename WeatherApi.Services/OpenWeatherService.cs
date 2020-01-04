using System;
using System.Net.Http;
using System.Collections.Generic;
using WeatherApi.Core.Abstractions.Services;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.Json;

namespace WeatherApi.Services
{
    public class OpenWeatherService : IOpenWeatherService
    {
        private readonly IHttpClientFactory _clientFactory;

        public OpenWeatherService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<JsonDocument> GetCurentWeather(string name)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                "https://api.openweathermap.org/data/2.5/weather?q=" + name + "&appid=5d60c80406f8941039d85837e08019a1");
            
            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var result = JsonDocument.Parse(responseString);

                return result;
            }
            else
            {
                if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    throw new HttpRequestException("NotFound");
                }
                else throw new Exception();
            }
        }

        public async Task<JsonDocument> GetWeatherFor5Day(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                 "http://api.openweathermap.org/data/2.5/forecast?id=" + id + "&appid=5d60c80406f8941039d85837e08019a1&units=metric");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var result = JsonDocument.Parse(responseString);

                return result;
            }
            else
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    throw new HttpRequestException("NotFound");
                }
                else throw new Exception();
            }
        }
    }
}
