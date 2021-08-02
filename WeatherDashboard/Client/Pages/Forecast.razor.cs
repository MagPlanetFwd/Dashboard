using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor.Data;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WeatherDashboard.Client.Data;
using WeatherDashboard.Client.ViewModels;

namespace WeatherDashboard.Client.Pages
{
    public class ForecastBase : ComponentBase
    {
        [Inject]
        public HttpClient Client { get; set; }

        protected ObservableCollection<WeatherGridRow> Forecasts { get; private set; }

        protected string SearchBox { get; set; }

        protected static Query GetQuery()
        {
            return Queries.GetQuery();
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
            if (string.IsNullOrEmpty(SearchBox))
            {
                return;
            }

            var city = SearchBox.Split(',')[0];
            var forecast = await Client.GetFromJsonAsync<WeatherGridRow>($"WeatherForecast/Get?city={city}");
            Forecasts.Add(forecast);
        }

        protected string GetSearchUrl()
        {
            return $"https://localhost:5001/LocationSearch?search={SearchBox}";
        }

        protected void OnAutoCompleteKeyPressed(KeyboardEventArgs args)
        {
            SearchBox += args.Key;
        }

        protected void OnAutoCompleteKeyUp(KeyboardEventArgs args)
        {
            if(args.Code == "Backspace" && SearchBox.Length > 0)
            {
                SearchBox = SearchBox.Remove(SearchBox.Length - 1);
            }
        }
    }
}
