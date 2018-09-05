using System.Threading.Tasks;
using MVC.Weather.Domain.DomainModel;

namespace MVC.Weather.Domain.Data.Abstract
{
    public interface IWeatherService
    {
        Task<Forecast> GetWeatherAsync(float latitude, float longitude);
    }
}