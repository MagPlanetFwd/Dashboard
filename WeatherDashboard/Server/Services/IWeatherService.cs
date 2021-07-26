using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherDashboard.Server.Services.Models;

namespace WeatherDashboard.Server.Services
{
    public interface IWeatherService
    {
        Task<IEnumerable<Forecast>> GetWeeklyForecast(string city);
    }
}
