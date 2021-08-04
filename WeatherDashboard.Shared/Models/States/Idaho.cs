using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Idaho : State
    {
        public Idaho()
        {
            Name = "Idaho";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Boise"
                },
                new City()
                {
                    Name = "Meridian"
                },
                new City()
                {
                    Name = "Nampa"
                },
                new City()
                {
                    Name = "Idaho Falls"
                },
                new City()
                {
                    Name = "Pocatello"
                }
            };
        }
    }
}
