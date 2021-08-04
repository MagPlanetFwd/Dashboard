using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class NorthDakota : State
    {
        public NorthDakota()
        {
            Name = "North Dakota";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Fargo"
                },
                new City()
                {
                    Name = "Bismarck"
                },
                new City()
                {
                    Name = "Grand Forks"
                },
                new City()
                {
                    Name = "Minot"
                },
                new City()
                {
                    Name = "West Fargo"
                }
            };
        }
    }
}
