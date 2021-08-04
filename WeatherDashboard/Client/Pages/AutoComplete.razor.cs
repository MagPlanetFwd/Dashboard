using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using WeatherDashboard.Shared.Models;

namespace WeatherDashboard.Client.Pages
{
    public class AutoCompleteBase : ComponentBase
    {
        protected IEnumerable<INamed> GetStates()
        {
            var states = new INamed[50];
            return states;
        }

        protected IEnumerable<INamed> GetCities()
        {
            return Array.Empty<INamed>();
        }
    }
}
