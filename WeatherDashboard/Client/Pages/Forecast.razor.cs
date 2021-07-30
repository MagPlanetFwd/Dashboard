using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WeatherDashboard.Client.ViewModels;

namespace WeatherDashboard.Client.Pages
{
    public class ForecastBase: ComponentBase
    {
        protected ObservableCollection<WeatherGridRow> Forecasts { get; private set; }
        protected string SearchBox { get; set; }

        [Inject]
        public HttpClient Client { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Forecasts = await Client.GetFromJsonAsync<ObservableCollection<WeatherGridRow>>("WeatherForecast/GetMultiple?" +
                "cities=seattle&" +
                "cities=portland&" +
                "cities=san francisco");
        }

        protected async void OnSearchClicked()
        {
            if (string.IsNullOrEmpty(SearchBox))
            {
                return;
            }

            var forecast = await Client.GetFromJsonAsync<WeatherGridRow>($"WeatherForecast/Get?city={SearchBox}");
            SearchBox = string.Empty;
            Forecasts.Add(forecast);
        }
    }
}
