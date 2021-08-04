using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Virginia : State
    {
        public Virginia()
        {
            Name = "Virginia";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Northern Virginia"
                },
                new City()
                {
                    Name = "Hampton Roads"
                },
                new City()
                {
                    Name = "Richmond"
                },
                new City()
                {
                    Name = "Roanoke"
                },
                new City()
                {
                    Name = "Lynchburg"
                }
            };
        }
    }
}
