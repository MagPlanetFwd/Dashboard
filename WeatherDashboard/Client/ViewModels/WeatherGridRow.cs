using WeatherDashboard.Shared.Models;

namespace WeatherDashboard.Client.ViewModels
{
    public class WeatherGridRow
    {
        public string City { get; set; }
        public DailyForecast Today { get; set; }
        public DailyForecast Tomorrow { get; set; }
        public DailyForecast ThirdDay { get; set; }
    }
}
