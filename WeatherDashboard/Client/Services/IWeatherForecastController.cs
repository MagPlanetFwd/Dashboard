using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherDashboard.Client.Models.ViewModels;

namespace WeatherDashboard.Client.Services
{
    public interface IWeatherForecastController
    {
        Task<IEnumerable<WeatherForecast>> Get();
    }
}
