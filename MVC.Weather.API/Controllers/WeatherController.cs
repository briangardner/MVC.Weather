using System.Threading.Tasks;
using System.Web.Http;
using MVC.Weather.API.Cache;
using MVC.Weather.Domain.Data.Abstract;
using MVC.Weather.Domain.DomainModel;
using MVC.Weather.Services.Weather;

namespace MVC.Weather.API.Controllers
{
    public class WeatherController : ApiController
    {
        private readonly IWeatherService _weatherService;
        private readonly RedisCacheClient _cacheClient;
        public WeatherController()
        {
            _weatherService = new BasicWeatherService();
            _cacheClient = new RedisCacheClient();
        }

        [HttpGet]
        public async Task<Forecast> Get(float latitude, float longitude)
        {
            return await _cacheClient.GetValue(Request.RequestUri.AbsoluteUri,
               async () => await _weatherService.GetWeatherAsync(latitude, longitude));
        }
    }
}
