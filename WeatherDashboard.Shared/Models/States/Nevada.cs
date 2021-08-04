using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Nevada : State
    {
        public Nevada()
        {
            Name = "Nevada";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Las Vegas"
                },
                new City()
                {
                    Name = "Henderson"
                },
                new City()
                {
                    Name = "Reno"
                },
                new City()
                {
                    Name = "North Las Vegas"
                },
                new City()
                {
                    Name = "Sparks"
                }
            };
        }
    }
}
