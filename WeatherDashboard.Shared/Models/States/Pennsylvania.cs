using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Pennsylvania : State
    {
        public Pennsylvania()
        {
            Name = "Pennsylvania";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Philadelphia"
                },
                new City()
                {
                    Name = "Pittsburgh"
                },
                new City()
                {
                    Name = "Allentown"
                },
                new City()
                {
                    Name = "Erie"
                },
                new City()
                {
                    Name = "Reading"
                }
            };
        }
    }
}
