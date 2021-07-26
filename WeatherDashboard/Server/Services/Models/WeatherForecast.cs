using System;
using System.Collections.Generic;
using WeatherDashboard.Client.Models.ViewModels;

namespace WeatherDashboard.Server.Services.Models
{
    public class WeatherForecast
    {
        public Forecast forecast { get; set; }

        public IEnumerable<WeatherGridRow> ToWeatherGridRows()
        {
            if(forecast == null)
            {
                return Array.Empty<WeatherGridRow>();
            }

            var days = forecast.forecastday;
            var n = days.Length;
            var rows = new WeatherGridRow[n];
            for(var i = 0; i < n; i++)
            {
                rows[i] = new WeatherGridRow()
                {
                    Date = days[i].date.ToString("MM/dd"),
                    TemperatureC = days[i].day.avgtemp_c
                };
            }

            return rows;
        }
    }
}
