using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Minnesota : State
    {
        public Minnesota()
        {
            Name = "Minnesota";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Minneapolis"
                },
                new City()
                {
                    Name = "Saint Paul"
                },
                new City()
                {
                    Name = "Rochester"
                },
                new City()
                {
                    Name = "Duluth"
                },
                new City()
                {
                    Name = "Bloomington"
                }
            };
        }
    }
}
