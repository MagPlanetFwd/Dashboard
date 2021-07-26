using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherDashboard.Client.ViewModels;

namespace WeatherDashboard.Client.Services
{
    public interface IWeatherForecastController
    {
        Task<IEnumerable<WeatherGridRow>> Get();
    }
}
