﻿using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Alaska : State
    {
        public Alaska()
        {
            Name = "Alaska";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Anchorage"
                },
                new City()
                {
                    Name = "Fairbanks"
                },
                new City()
                {
                    Name = "Juneau"
                },
                new City()
                {
                    Name = "Sitka"
                },
                new City()
                {
                    Name = "Ketchikan"
                }
            };
        }
    }
}