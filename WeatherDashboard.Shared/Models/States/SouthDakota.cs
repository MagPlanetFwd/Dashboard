using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class SouthDakota : State
    {
        public SouthDakota()
        {
            Name = "South Dakota";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Sioux Falls"
                },
                new City()
                {
                    Name = "Rapid City"
                },
                new City()
                {
                    Name = "Aberdeen"
                },
                new City()
                {
                    Name = "Brookings"
                },
                new City()
                {
                    Name = "Watertown"
                }
            };
        }
    }
}
