using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherDashboard.Shared;

namespace WeatherDashboard.Server.Services
{
    public interface IWeatherService
    {
        Task<string> GetWeeklyForecast(string city);
    }
}
