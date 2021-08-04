using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Washington : State
    {
        public Washington()
        {
            Name = "Washington";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Seattle"
                },
                new City()
                {
                    Name = "Spokane"
                },
                new City()
                {
                    Name = "Tacoma"
                },
                new City()
                {
                    Name = "Vancouver"
                },
                new City()
                {
                    Name = "Bellevue"
                }
            };
        }
    }
}
