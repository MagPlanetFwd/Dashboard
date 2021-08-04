using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Texas : State
    {
        public Texas()
        {
            Name = "Texas";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Houston"
                },
                new City()
                {
                    Name = "San Antonio"
                },
                new City()
                {
                    Name = "Dallas"
                },
                new City()
                {
                    Name = "Austin"
                },
                new City()
                {
                    Name = "Fort Worth"
                }
            };
        }
    }
}
