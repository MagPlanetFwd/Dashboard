using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Vermont : State
    {
        public Vermont()
        {
            Name = "Vermont";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Burlington"
                },
                new City()
                {
                    Name = "Essex"
                },
                new City()
                {
                    Name = "South Burlington"
                },
                new City()
                {
                    Name = "Colchester"
                },
                new City()
                {
                    Name = "Rutland"
                }
            };
        }
    }
}
