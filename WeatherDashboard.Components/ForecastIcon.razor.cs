using Microsoft.AspNetCore.Components;
using WeatherDashboard.Shared.Models;

namespace WeatherDashboard.Components
{
    public class ForecastIconBase : ComponentBase
    {
        [Parameter]
        public DailyWeather DailyForecast { get; set; }
    }
}
