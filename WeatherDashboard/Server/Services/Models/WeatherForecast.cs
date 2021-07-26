using WeatherDashboard.Client.Models.ViewModels;

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
                Today = Forecast.Forecastday[0].Day.Avgtemp_c,
                Tomorrow = Forecast.Forecastday[1].Day.Avgtemp_c,
                ThirdDay = Forecast.Forecastday[2].Day.Avgtemp_c
            };
        }
    }
}
