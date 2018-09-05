using System.Threading.Tasks;
using System.Web.Mvc;
using MVC.Weather.Clients;
using MVC.Weather.Models;

namespace MVC.Weather.Controllers
{
    public class WeatherController : Controller
    {
        private readonly WeatherClient _weatherClient;
        public WeatherController()
        {
            _weatherClient = new WeatherClient();
        }
        // GET: Weather
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> GetWeather(LocationViewModel location)
        {
            var forecast = await _weatherClient.GetForecast(location.Latitude, location.Longitude);
            return View(forecast);
        }
    }
}
