using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Missouri : State
    {
        public Missouri()
        {
            Name = "Missouri";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Kansas City"
                },
                new City()
                {
                    Name = "St. Louis"
                },
                new City()
                {
                    Name = "Springfield"
                },
                new City()
                {
                    Name = "Columbia"
                },
                new City()
                {
                    Name = "Independence"
                }
            };
        }
    }
}
