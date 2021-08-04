using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class California : State
    {
        public California()
        {
            Name = "California";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Los Angeles"
                },
                new City()
                {
                    Name = "San Diego"
                },
                new City()
                {
                    Name = "San Jose"
                },
                new City()
                {
                    Name = "San Francisco"
                },
                new City()
                {
                    Name = "Fresno"
                }
            };
        }
    }
}
