using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Delaware : State
    {
        public Delaware()
        {
            Name = "Delaware";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Wilmington"
                },
                new City()
                {
                    Name = "Dover"
                },
                new City()
                {
                    Name = "Newark"
                },
                new City()
                {
                    Name = "Middleton"
                },
                new City()
                {
                    Name = "Smyrna"
                }
            };
        }
    }
}
