using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Nebraska : State
    {
        public Nebraska()
        {
            Name = "Nebraska";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Omaha"
                },
                new City()
                {
                    Name = "Lincoln"
                },
                new City()
                {
                    Name = "Bellevue"
                },
                new City()
                {
                    Name = "Grand Island"
                },
                new City()
                {
                    Name = "Kearney"
                }
            };
        }
    }
}
