using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Kansas : State
    {
        public Kansas()
        {
            Name = "Kansas";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Wichita"
                },
                new City()
                {
                    Name = "Overland Park"
                },
                new City()
                {
                    Name = "Kansas City"
                },
                new City()
                {
                    Name = "Olathe"
                },
                new City()
                {
                    Name = "Topeka"
                }
            };
        }
    }
}
