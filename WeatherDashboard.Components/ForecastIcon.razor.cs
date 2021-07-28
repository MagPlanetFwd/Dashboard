using Microsoft.AspNetCore.Components;
using WeatherDashboard.Shared;

namespace WeatherDashboard.Components
{
    public class ForecastIconBase : ComponentBase
    {
        [Parameter]
        public DailyForecast DailyForecast { get; set; }
    }
}
