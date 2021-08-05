using System;
using System.Collections.Generic;
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
                Today = new DailyWeather()
                {
                    Low = Forecast.Forecastday[0].Day.Mintemp_c,
                    High = Forecast.Forecastday[0].Day.Maxtemp_c,
                    Icon = Forecast.Forecastday[0].Day.Condition.Icon
                },
                Tomorrow = new DailyWeather()
                {
                    Low = Forecast.Forecastday[1].Day.Mintemp_c,
                    High = Forecast.Forecastday[1].Day.Maxtemp_c,
                    Icon = Forecast.Forecastday[1].Day.Condition.Icon
                },
                ThirdDay = new DailyWeather()
                {
                    Low = Forecast.Forecastday[2].Day.Mintemp_c,
                    High = Forecast.Forecastday[2].Day.Maxtemp_c,
                    Icon = Forecast.Forecastday[2].Day.Condition.Icon
                },
            };
        }

        public HistoricalWeather ToHistoricalWeather()
        {
            if(Forecast == null)
            {
                return new HistoricalWeather();
            }

            var n = Forecast.Forecastday.Length;
            var weathers = new DailyWeather[n];

            for(var i = 0; i < n; i++)
            {
                weathers[i] = new DailyWeather()
                {
                    Date = DateTime.Today.AddDays(i - n),
                    High = Forecast.Forecastday[i].Day.Maxtemp_c,
                    Low = Forecast.Forecastday[i].Day.Mintemp_c
                };
            }

            return new HistoricalWeather()
            {
                DailyWeathers = weathers
            };
        }
    }
}
