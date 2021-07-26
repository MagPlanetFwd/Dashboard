using System;

namespace WeatherDashboard.Server.Services.Models
{
    public class ForecastDay
    {
        public DateTime date { get; set; }
        public Day day { get; set; }
    }
}
