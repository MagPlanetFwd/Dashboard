using WeatherDashboard.Client.ViewModels;
using WeatherDashboard.Shared.Models;

namespace WeatherDashboard.Server.Services.Models
{
    public class WeatherForecast
    {
        public Location Location { get; set; }
        public Forecast Forecast { get; set; }

        public WeatherGridRow ToWeatherGridRow()
        {
            if(Forecast == null)
            {
                return new WeatherGridRow();
            }

            return new WeatherGridRow()
            {
                City = Location.Name,
                Today = new DailyForecast()
                {
                    Low = Forecast.Forecastday[0].Day.Mintemp_c,
                    High = Forecast.Forecastday[0].Day.Maxtemp_c,
                    Icon = Forecast.Forecastday[0].Day.Condition.Icon
                },
                Tomorrow = new DailyForecast()
                {
                    Low = Forecast.Forecastday[1].Day.Mintemp_c,
                    High = Forecast.Forecastday[1].Day.Maxtemp_c,
                    Icon = Forecast.Forecastday[1].Day.Condition.Icon
                },
                ThirdDay = new DailyForecast()
                {
                    Low = Forecast.Forecastday[2].Day.Mintemp_c,
                    High = Forecast.Forecastday[2].Day.Maxtemp_c,
                    Icon = Forecast.Forecastday[2].Day.Condition.Icon
                },
            };
        }
    }
}
