using WeatherDashboard.Client.Models.ViewModels;

namespace WeatherDashboard.Server.Services.Models
{
    public class WeatherForecast
    {
        public Location location { get; set; }
        public Forecast forecast { get; set; }

        public WeatherGridRow ToWeatherGridRow()
        {
            if(forecast == null)
            {
                return new WeatherGridRow();
            }

            return new WeatherGridRow()
            {
                City = location.name,
                Today = forecast.forecastday[0].day.avgtemp_c,
                Tomorrow = forecast.forecastday[1].day.avgtemp_c,
                ThirdDay = forecast.forecastday[2].day.avgtemp_c
            };
        }
    }
}
