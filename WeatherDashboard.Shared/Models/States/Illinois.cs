using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Illinois : State
    {
        public Illinois()
        {
            Name = "Illinois";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Chicago"
                },
                new City()
                {
                    Name = "Aurora"
                },
                new City()
                {
                    Name = "Naperville"
                },
                new City()
                {
                    Name = "Joliet"
                },
                new City()
                {
                    Name = "Rockford"
                }
            };
        }
    }
}
