using System.Configuration;
using System.Threading.Tasks;
using MVC.Weather.Domain.DomainModel;
using Newtonsoft.Json;
using RestSharp;

namespace MVC.Weather.Clients
{
    public class WeatherClient
    {
        private readonly IRestClient _client;
        public WeatherClient()
        {
            _client = new RestClient(ConfigurationManager.AppSettings["WeatherApiBaseUrl"]);
        }
        public async Task<Forecast> GetForecast(float latitude, float longitude)
        {
            var request = new RestRequest("api/Weather", Method.GET);
            request.Parameters.Add(new Parameter()
            {
                Name = "latitude",
                Type = ParameterType.QueryString,
                Value = latitude
            });
            request.Parameters.Add(new Parameter()
            {
                Name = "longitude",
                Type = ParameterType.QueryString,
                Value = longitude
            });

            var response = await _client.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<Forecast>(response.Content);
        }
    }
}