using System.Collections.Generic;
using WeatherDashboard.Shared.Models;

namespace WeatherDashboard.Client.ViewModels
{
    public class HistoricalWeather
    {
        public string City { get; set; }
        public IEnumerable<DailyWeather> DailyWeathers { get; set; }
    }
}
