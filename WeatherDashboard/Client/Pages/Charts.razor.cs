using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WeatherDashboard.Client.ViewModels;

namespace WeatherDashboard.Client.Pages
{
    public class ChartsBase : ComponentBase
    {
        [Inject]
        public HttpClient Client { get; set; }

        protected IEnumerable<HistoricalWeather> HistoricalWeather { get; private set; }

        protected override async Task OnInitializedAsync()
        {
            var weather = await Client.GetFromJsonAsync<IEnumerable<HistoricalWeather>>("HistoricalWeather?city=seattle");
            HistoricalWeather = weather;
        }
    }
}
