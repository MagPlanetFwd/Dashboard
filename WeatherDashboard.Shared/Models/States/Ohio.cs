using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Ohio : State
    {
        public Ohio()
        {
            Name = "Ohio";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Columbus"
                },
                new City()
                {
                    Name = "Cleveland"
                },
                new City()
                {
                    Name = "Cincinnati"
                },
                new City()
                {
                    Name = "Toledo"
                },
                new City()
                {
                    Name = "Akron"
                }
            };
        }
    }
}
