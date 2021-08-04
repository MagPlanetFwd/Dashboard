using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Massachusetts : State
    {
        public Massachusetts()
        {
            Name = "Massachusetts";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Boston"
                },
                new City()
                {
                    Name = "Worcester"
                },
                new City()
                {
                    Name = "Springfield"
                },
                new City()
                {
                    Name = "Cambridge"
                },
                new City()
                {
                    Name = "Lowell"
                }
            };
        }
    }
}
