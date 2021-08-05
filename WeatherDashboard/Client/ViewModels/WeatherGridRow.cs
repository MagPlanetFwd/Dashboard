using WeatherDashboard.Shared.Models;

namespace WeatherDashboard.Client.ViewModels
{
    public class WeatherGridRow
    {
        public string City { get; set; }
        public DailyWeather Today { get; set; }
        public DailyWeather Tomorrow { get; set; }
        public DailyWeather ThirdDay { get; set; }
    }
}
