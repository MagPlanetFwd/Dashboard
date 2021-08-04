using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Colorado : State
    {
        public Colorado()
        {
            Name = "Colorado";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Denver"
                },
                new City()
                {
                    Name = "Colorado Springs"
                },
                new City()
                {
                    Name = "Aurora"
                },
                new City()
                {
                    Name = "Fort Collins"
                },
                new City()
                {
                    Name = "Lakewood"
                }
            };
        }
    }
}
