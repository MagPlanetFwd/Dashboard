using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Connecticut : State
    {
        public Connecticut()
        {
            Name = "Connecticut";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Bridgeport"
                },
                new City()
                {
                    Name = "New Haven"
                },
                new City()
                {
                    Name = "Stamford"
                },
                new City()
                {
                    Name = "Hartford"
                },
                new City()
                {
                    Name = "Waterbury"
                }
            };
        }
    }
}
