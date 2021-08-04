using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class NewHampshire : State
    {
        public NewHampshire()
        {
            Name = "New Hampshire";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Manchester"
                },
                new City()
                {
                    Name = "Nashua"
                },
                new City()
                {
                    Name = "Concord"
                },
                new City()
                {
                    Name = "Derry"
                },
                new City()
                {
                    Name = "Dover"
                }
            };
        }
    }
}
