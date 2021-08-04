using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class WestVirginia : State
    {
        public WestVirginia()
        {
            Name = "West Virginia";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Charleston"
                },
                new City()
                {
                    Name = "Huntington"
                },
                new City()
                {
                    Name = "Morgantown"
                },
                new City()
                {
                    Name = "Parkersburg"
                },
                new City()
                {
                    Name = "Wheeling"
                }
            };
        }
    }
}
