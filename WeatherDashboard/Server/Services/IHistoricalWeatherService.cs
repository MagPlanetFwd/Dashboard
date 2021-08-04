using System.Threading.Tasks;
using WeatherDashboard.Server.Services.Models;

namespace WeatherDashboard.Server.Services
{
    public interface IHistoricalWeatherService
    {
        Task<WeatherForecast> GetHistoricalWeather(string city);
    }
}
