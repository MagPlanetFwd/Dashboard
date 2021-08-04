using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using WeatherDashboard.Client.Services;
using WeatherDashboard.Shared.Models;

namespace WeatherDashboard.Client.Pages
{
    public class AutoCompleteBase : ComponentBase
    {
        [Inject]
        public LocationsProvider Locations { get; set; }

        protected IEnumerable<INamed> GetStates()
        {
            return Locations.GetStates();
        }

        protected IEnumerable<INamed> GetCities()
        {
            return Array.Empty<INamed>();
        }
    }
}
