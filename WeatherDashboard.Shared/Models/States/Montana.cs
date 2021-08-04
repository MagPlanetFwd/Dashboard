using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Montana : State
    {
        public Montana()
        {
            Name = "Montana";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Billings"
                },
                new City()
                {
                    Name = "Missoula"
                },
                new City()
                {
                    Name = "Great Falls"
                },
                new City()
                {
                    Name = "Bozeman"
                },
                new City()
                {
                    Name = "Butte"
                }
            };
        }
    }
}
