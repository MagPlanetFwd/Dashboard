using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Tennessee : State
    {
        public Tennessee()
        {
            Name = "Tennessee";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Nashville"
                },
                new City()
                {
                    Name = "Memphis"
                },
                new City()
                {
                    Name = "Knoxville"
                },
                new City()
                {
                    Name = "Chattanooga"
                },
                new City()
                {
                    Name = "Clarksville"
                }
            };
        }
    }
}
