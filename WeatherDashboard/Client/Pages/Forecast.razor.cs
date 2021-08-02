﻿using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WeatherDashboard.Client.ViewModels;

namespace WeatherDashboard.Client.Pages
{
    public class ForecastBase : ComponentBase
    {
        public Query Query => new Query().Select(new List<string> { "Name" }).RequiresCount();

        [Inject]
        public HttpClient Client { get; set; }

        protected ObservableCollection<WeatherGridRow> Forecasts { get; private set; }

        protected string SearchBox { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Forecasts = await Client.GetFromJsonAsync<ObservableCollection<WeatherGridRow>>("WeatherForecast/GetMultiple?" +
                "cities=seattle&" +
                "cities=portland&" +
                "cities=san francisco");
        }

        protected async void OnAddClicked()
        {
            if (string.IsNullOrEmpty(SearchBox))
            {
                return;
            }

            var forecast = await Client.GetFromJsonAsync<WeatherGridRow>($"WeatherForecast/Get?city={SearchBox}");
            Forecasts.Add(forecast);
        }
    }
}
