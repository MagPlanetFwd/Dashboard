using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WeatherDashboard.Client.ViewModels;

namespace WeatherDashboard.Client.Pages
{
    public class ForecastBase: ComponentBase
    {
        protected ObservableCollection<WeatherGridRow> Forecasts { get; private set; } = new ObservableCollection<WeatherGridRow>();

        [Inject]
        public HttpClient Client { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var forecasts = await Client.GetFromJsonAsync<IEnumerable<WeatherGridRow>>("WeatherForecast?" +
                "cities=seattle&" +
                "cities=portland&" +
                "cities=san francisco");
            forecasts.ToList().ForEach(wgr => Forecasts.Add(wgr));
        }
    }
}
