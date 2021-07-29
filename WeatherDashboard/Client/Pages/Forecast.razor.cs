using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WeatherDashboard.Client.ViewModels;

namespace WeatherDashboard.Client.Pages
{
    public class ForecastBase: ComponentBase
    {
        protected WeatherGridRow[] Forecasts { get; private set; }

        [Inject]
        public HttpClient Client { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Forecasts = await Client.GetFromJsonAsync<WeatherGridRow[]>("WeatherForecast?" +
                "cities=seattle&" +
                "cities=portland&" +
                "cities=san francisco");
        }
    }
}
