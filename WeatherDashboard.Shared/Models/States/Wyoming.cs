using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Wyoming : State
    {
        public Wyoming()
        {
            Name = "Wyoming";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Cheyenne"
                },
                new City()
                {
                    Name = "Casper"
                },
                new City()
                {
                    Name = "Laramie"
                },
                new City()
                {
                    Name = "Gillette"
                },
                new City()
                {
                    Name = "Rock Springs"
                }
            };
        }
    }
}
