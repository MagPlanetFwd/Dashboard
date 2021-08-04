using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Hawaii : State
    {
        public Hawaii()
        {
            Name = "Hawaii";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Honolulu"
                },
                new City()
                {
                    Name = "East Honolulu"
                },
                new City()
                {
                    Name = "Pearl City"
                },
                new City()
                {
                    Name = "Hilo"
                },
                new City()
                {
                    Name = "Kailua"
                }
            };
        }
    }
}
