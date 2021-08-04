using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Florida : State
    {
        public Florida()
        {
            Name = "Florida";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Jacksonville"
                },
                new City()
                {
                    Name = "Miami"
                },
                new City()
                {
                    Name = "Tampa"
                },
                new City()
                {
                    Name = "Orlando"
                },
                new City()
                {
                    Name = "St. Petersburg"
                }
            };
        }
    }
}
