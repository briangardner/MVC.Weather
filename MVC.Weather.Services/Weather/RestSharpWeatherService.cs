using System.Configuration;
using System.Threading.Tasks;
using MVC.Weather.Domain.Data.Abstract;
using MVC.Weather.Domain.DomainModel;
using RestSharp;

namespace MVC.Weather.Services.Weather
{
    public class RestSharpWeatherService : IWeatherService
    {
        private readonly IRestClient _client;
        public RestSharpWeatherService()
        {
            _client = new RestClient(ConfigurationManager.AppSettings["BaseWeatherUri"]);
        }
        public async Task<Forecast> GetWeatherAsync(float latitude, float longitude)
        {
            var request = new RestRequest(string.Format(ConfigurationManager.AppSettings["WeatherEndpoint"], latitude, longitude), Method.GET);
            var response = await _client.ExecuteTaskAsync<Forecast>(request);
            return response.Data;

        }
    }
}
