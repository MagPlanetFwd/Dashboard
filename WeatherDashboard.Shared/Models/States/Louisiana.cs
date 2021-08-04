using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Louisiana : State
    {
        public Louisiana()
        {
            Name = "Louisiana";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "New Orleans"
                },
                new City()
                {
                    Name = "Baton Rouge"
                },
                new City()
                {
                    Name = "Shreveport"
                },
                new City()
                {
                    Name = "Lafayette"
                },
                new City()
                {
                    Name = "Lake Charles"
                }
            };
        }
    }
}
