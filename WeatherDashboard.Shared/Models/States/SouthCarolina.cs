using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class SouthCarolina : State
    {
        public SouthCarolina()
        {
            Name = "South Carolina";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Columbia"
                },
                new City()
                {
                    Name = "Charleston"
                },
                new City()
                {
                    Name = "North Charleston"
                },
                new City()
                {
                    Name = "Mount Pleasant"
                },
                new City()
                {
                    Name = "Rock Hill"
                }
            };
        }
    }
}
