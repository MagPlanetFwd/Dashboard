using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Arizona : State
    {
        public Arizona()
        {
            Name = "Arizona";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Phoenix"
                },
                new City()
                {
                    Name = "Tucson"
                },
                new City()
                {
                    Name = "Mesa"
                },
                new City()
                {
                    Name = "Chandler"
                },
                new City()
                {
                    Name = "Glendale"
                }
            };
        }
    }
}
