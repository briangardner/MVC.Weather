using System;
using System.Configuration;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using MVC.Weather.Domain.Data.Abstract;
using MVC.Weather.Domain.DomainModel;
using Newtonsoft.Json;

namespace MVC.Weather.Services.Weather
{
    public class BasicWeatherService : IWeatherService
    {
        private readonly HttpClient _client;

        public BasicWeatherService()
        {
            _client = new HttpClient()
            {
                BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseWeatherUri"])
            };
        }

        public async Task<Forecast> GetWeatherAsync(float latitude, float longitude)
        {
            Forecast forecast = null;
            var request = new HttpRequestMessage(HttpMethod.Get, string.Format(ConfigurationManager.AppSettings["WeatherEndpoint"], latitude, longitude));
            request.Headers.Add("User-Agent", "RestSharp");
            request.Headers.Add("Accept", "application/json");
            var response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Forecast>(data);
            }
            else
            {
                var data = await response.Content.ReadAsStringAsync();
                Trace.WriteLine($"ERROR GETTING DATA: Status Code: {response.StatusCode} - Content: {data}");
            }
            return forecast;
        }

    }
}
