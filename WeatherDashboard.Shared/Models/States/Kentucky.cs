using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Kentucky : State
    {
        public Kentucky()
        {
            Name = "Kentucky";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Louisville"
                },
                new City()
                {
                    Name = "Lexington"
                },
                new City()
                {
                    Name = "Bowling Green"
                },
                new City()
                {
                    Name = "Owensboro"
                },
                new City()
                {
                    Name = "Covington"
                }
            };
        }
    }
}
