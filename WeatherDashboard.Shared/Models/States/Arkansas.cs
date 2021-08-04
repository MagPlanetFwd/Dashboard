using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Arkansas : State
    {
        public Arkansas()
        {
            Name = "Arkansas";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Little Rock"
                },
                new City()
                {
                    Name = "Fort Smith"
                },
                new City()
                {
                    Name = "Fayetteville"
                },
                new City()
                {
                    Name = "Springdale"
                },
                new City()
                {
                    Name = "Jonesboro"
                }
            };
        }
    }
}
