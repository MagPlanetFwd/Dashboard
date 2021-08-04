using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Georgia : State
    {
        public Georgia()
        {
            Name = "Georgia";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Atlanta"
                },
                new City()
                {
                    Name = "Augusta"
                },
                new City()
                {
                    Name = "Columbus"
                },
                new City()
                {
                    Name = "Macon"
                },
                new City()
                {
                    Name = "Savannah"
                }
            };
        }
    }
}
