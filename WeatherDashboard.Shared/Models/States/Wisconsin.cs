using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Wisconsin : State
    {
        public Wisconsin()
        {
            Name = "Wisconsin";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Milwaukee"
                },
                new City()
                {
                    Name = "Madison"
                },
                new City()
                {
                    Name = "Green Bay"
                },
                new City()
                {
                    Name = "Kenosha"
                },
                new City()
                {
                    Name = "Racine"
                }
            };
        }
    }
}
