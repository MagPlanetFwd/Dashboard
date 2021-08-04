using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class NewJersey : State
    {
        public NewJersey()
        {
            Name = "New Jersey";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Newark"
                },
                new City()
                {
                    Name = "Jersey City"
                },
                new City()
                {
                    Name = "Paterson"
                },
                new City()
                {
                    Name = "Elizabeth"
                },
                new City()
                {
                    Name = "Edison"
                }
            };
        }
    }
}
