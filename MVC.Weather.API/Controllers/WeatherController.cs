using System.Threading.Tasks;
using System.Web.Http;
using MVC.Weather.Domain.Data.Abstract;
using MVC.Weather.Domain.DomainModel;
using MVC.Weather.Services.Weather;

namespace MVC.Weather.API.Controllers
{
    public class WeatherController : ApiController
    {
        private readonly IWeatherService _weatherService;
        public WeatherController()
        {
            _weatherService = new BasicWeatherService();
        }

        [HttpGet]
        public async Task<Forecast> Get(float latitude, float longitude)
        {
            return await _weatherService.GetWeatherAsync(latitude, longitude);
        }
    }
}
