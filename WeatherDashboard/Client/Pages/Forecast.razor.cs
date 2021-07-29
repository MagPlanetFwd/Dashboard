using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WeatherDashboard.Client.ViewModels;

namespace WeatherDashboard.Client.Pages
{
    public class ForecastBase: ComponentBase
    {
        protected IEnumerable<WeatherGridRow> Forecasts { get; private set; }

        [Inject]
        public HttpClient Client { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Forecasts = await Client.GetFromJsonAsync<IEnumerable<WeatherGridRow>>("WeatherForecast?" +
                "cities=seattle&" +
                "cities=portland&" +
                "cities=san francisco");
        }
    }
}
