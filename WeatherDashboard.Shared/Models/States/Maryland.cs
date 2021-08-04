using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Maryland : State
    {
        public Maryland()
        {
            Name = "Maryland";
            Cities = new List<City>() 
            {
                new City()
                {
                    Name = "Baltimore"
                },
                new City()
                {
                    Name = "Columbia"
                },
                new City()
                {
                    Name = "Germantown"
                },
                new City()
                {
                    Name = "Silver Spring"
                },
                new City()
                {
                    Name = "Waldorf"
                }
            };
        }
    }
}
