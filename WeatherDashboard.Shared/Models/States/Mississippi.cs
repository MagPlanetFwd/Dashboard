using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Mississippi : State
    {
        public Mississippi()
        {
            Name = "Mississippi";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Jackson"
                },
                new City()
                {
                    Name = "Guflport"
                },
                new City()
                {
                    Name = "Southaven"
                },
                new City()
                {
                    Name = "Hattiesburg"
                },
                new City()
                {
                    Name = "Biloxi"
                }
            };
        }
    }
}
