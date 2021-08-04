using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class NewMexico : State
    {
        public NewMexico()
        {
            Name = "New Mexico";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Albuquerque"
                },
                new City()
                {
                    Name = "Las Cruces"
                },
                new City()
                {
                    Name = "Rio Rancho"
                },
                new City()
                {
                    Name = "Santa Fe"
                },
                new City()
                {
                    Name = "Roswell"
                }
            };
        }
    }
}
