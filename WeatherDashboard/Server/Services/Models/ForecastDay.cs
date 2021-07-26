using System;

namespace WeatherDashboard.Server.Services.Models
{
    public class ForecastDay
    {
        public DateTime Date { get; set; }
        public Day Day { get; set; }
    }
}
