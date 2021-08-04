using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherDashboard.Shared.Models;
using WeatherDashboard.Shared.Models.States;

namespace WeatherDashboard.Client.Services
{
    public class LocationsProvider
    {
        private readonly State[] _states;

        public LocationsProvider()
        {
            _states = new State[]
            {
                new Alabama(),
                new Alaska(),
                new Arizona(),
                new Arkansas(),
                new California(),
                new Colorado(),
                new Connecticut(),

            };
        }
    }
}
