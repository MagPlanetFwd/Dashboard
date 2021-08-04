using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Oklahoma : State
    {
        public Oklahoma()
        {
            Name = "Oklahoma";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Oklahoma City"
                },
                new City()
                {
                    Name = "Tulsa"
                },
                new City()
                {
                    Name = "Norman"
                },
                new City()
                {
                    Name = "Broken Arrow"
                },
                new City()
                {
                    Name = "Edmond"
                }
            };
        }
    }
}
