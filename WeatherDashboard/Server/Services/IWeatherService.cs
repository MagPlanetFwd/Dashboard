using System.Threading.Tasks;
using WeatherDashboard.Server.Services.Models;

namespace WeatherDashboard.Server.Services
{
    public interface IWeatherService
    {
        Task<WeatherForecast> Get3DayForecast(string city);
    }
}
