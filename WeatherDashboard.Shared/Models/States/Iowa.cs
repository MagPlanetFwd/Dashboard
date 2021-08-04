using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Iowa : State
    {
        public Iowa()
        {
            Name = "Iowa";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Des Moines"
                },
                new City()
                {
                    Name = "Cedar Rapids"
                },
                new City()
                {
                    Name = "Davenport"
                },
                new City()
                {
                    Name = "Sioux City"
                },
                new City()
                {
                    Name = "Waterloo"
                }
            };
        }
    }
}
