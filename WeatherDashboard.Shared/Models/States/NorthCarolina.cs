using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class NorthCarolina : State
    {
        public NorthCarolina()
        {
            Name = "North Carolina";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Charlotte"
                },
                new City()
                {
                    Name = "Raleigh"
                },
                new City()
                {
                    Name = "Greensboro"
                },
                new City()
                {
                    Name = "Durham"
                },
                new City()
                {
                    Name = "Winston-Salem"
                }
            };
        }
    }
}
