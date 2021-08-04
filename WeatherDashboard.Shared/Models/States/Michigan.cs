using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Michigan : State
    {
        public Michigan()
        {
            Name = "Michigan";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Detroit"
                },
                new City()
                {
                    Name = "Grand Rapids"
                },
                new City()
                {
                    Name = "Warren"
                },
                new City()
                {
                    Name = "Sterling Heights"
                },
                new City()
                {
                    Name = "Ann Arbor"
                }
            };
        }
    }
}
