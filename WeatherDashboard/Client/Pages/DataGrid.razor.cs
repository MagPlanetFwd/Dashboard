using Microsoft.AspNetCore.Components;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WeatherDashboard.Client.ViewModels;

namespace WeatherDashboard.Client.Pages
{
    public class DataGridBase : ComponentBase
    {
        [Inject]
        public HttpClient Client { get; set; }

        protected string City { get; set; }

        protected ObservableCollection<WeatherGridRow> Forecasts { get; private set; }

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
