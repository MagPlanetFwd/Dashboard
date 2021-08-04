using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class NewYork : State
    {
        public NewYork()
        {
            Name = "New York";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "New York"
                },
                new City()
                {
                    Name = "Buffalo"
                },
                new City()
                {
                    Name = "Rochester"
                },
                new City()
                {
                    Name = "Yonkers"
                },
                new City()
                {
                    Name = "Syracuse"
                }
            };
        }
    }
}
