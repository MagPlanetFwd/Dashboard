using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Utah : State
    {
        public Utah()
        {
            Name = "Utah";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Salt Lake City"
                },
                new City()
                {
                    Name = "West Valley City"
                },
                new City()
                {
                    Name = "Provo"
                },
                new City()
                {
                    Name = "West Jordan"
                },
                new City()
                {
                    Name = "Orem"
                }
            };
        }
    }
}
