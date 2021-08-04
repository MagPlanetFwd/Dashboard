using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Maine : State
    {
        public Maine()
        {
            Name = "Maine";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Portland"
                },
                new City()
                {
                    Name = "Lewiston"
                },
                new City()
                {
                    Name = "Bangor"
                },
                new City()
                {
                    Name = "South Portland"
                },
                new City()
                {
                    Name = "Auburn"
                }
            };
        }
    }
}
