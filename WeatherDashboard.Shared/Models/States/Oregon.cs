using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Oregon : State
    {
        public Oregon()
        {
            Name = "Oregon";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Portland"
                },
                new City()
                {
                    Name = "Salem"
                },
                new City()
                {
                    Name = "Eugene"
                },
                new City()
                {
                    Name = "Gresham"
                },
                new City()
                {
                    Name = "Hillsboro"
                }
            };
        }
    }
}
