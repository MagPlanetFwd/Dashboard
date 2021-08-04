using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Alabama : State
    {
        public Alabama()
        {
            Name = "Alabama";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Birmingham"
                },
                new City()
                {
                    Name = "Huntsville"
                },
                new City()
                {
                    Name = "Montgomery"
                },
                new City()
                {
                    Name = "Mobile"
                },
                new City()
                {
                    Name = "Tuscaloosa"
                }
            };
        }
    }
}
