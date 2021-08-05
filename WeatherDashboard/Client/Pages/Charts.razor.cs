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

        protected List<HistoricalWeather> Sources { get; private set; }

        protected override async Task OnInitializedAsync()
        {
            Sources = new List<HistoricalWeather>();

            var weathers = await Client.GetFromJsonAsync<List<HistoricalWeather>>("HistoricalWeather/GetMultiple?" +
                "cities=Seattle&" +
                "cities=San Francisco&" +
                "cities=Portland");

            Sources.AddRange(weathers);
        }
    }
}
