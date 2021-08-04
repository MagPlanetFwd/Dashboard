using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class RhodeIsland : State
    {
        public RhodeIsland()
        {
            Name = "Rhode Island";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Providence"
                },
                new City()
                {
                    Name = "Warwick"
                },
                new City()
                {
                    Name = "Cranston"
                },
                new City()
                {
                    Name = "Pawtucket"
                },
                new City()
                {
                    Name = "East Providence"
                }
            };
        }
    }
}
