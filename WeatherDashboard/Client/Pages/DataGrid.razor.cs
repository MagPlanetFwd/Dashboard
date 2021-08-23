using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor.Data;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WeatherDashboard.Client.ViewModels;
using WeatherDashboard.Shared.Data;

namespace WeatherDashboard.Client.Pages
{
    public class DataGridBase : ComponentBase
    {
        [Inject]
        public HttpClient Client { get; set; }

        protected string City { get; set; }

        protected ObservableCollection<WeatherGridRow> Forecasts { get; private set; }

        protected string RemoteSearch { get; set; }

        protected static Query GetQuery()
        {
            return Queries.GetQuery();
        }

        protected string GetSearchUrl()
        {
            return $"https://localhost:5001/LocationSearch?search={RemoteSearch}";
        }

        protected void OnAutoCompleteKeyPressed(KeyboardEventArgs args)
        {
            RemoteSearch += args.Key;
        }

        protected void OnAutoCompleteKeyDown(KeyboardEventArgs args)
        {
            if (args.Code == "Backspace" && RemoteSearch.Length > 0)
            {
                RemoteSearch = RemoteSearch.Remove(RemoteSearch.Length - 1);
            }
        }

        protected override async Task OnInitializedAsync()
        {
            Forecasts = await Client.GetFromJsonAsync<ObservableCollection<WeatherGridRow>>("WeatherForecast/GetMultiple?" +
                "cities=seattle&" +
                "cities=portland&" +
                "cities=san francisco");
        }

        protected async void OnAddClicked()
        {
            var forecast = await Client.GetFromJsonAsync<WeatherGridRow>($"WeatherForecast/Get?city={City}");
            Forecasts.Add(forecast);
        }
    }
}
