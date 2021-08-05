using Microsoft.AspNetCore.Mvc;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherDashboard.Client.ViewModels;
using WeatherDashboard.Server.Services;

namespace WeatherDashboard.Server.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class HistoricalWeatherController : ControllerBase
    {
        private readonly IHistoricalWeatherService _service;

        public HistoricalWeatherController(IHistoricalWeatherService historicalWeatherService)
        {
            _service = historicalWeatherService;
        }

        [HttpGet]
        public async Task<HistoricalWeather> Get([FromQuery(Name = "city")] string city)
        {
            var forecast = await _service.GetHistoricalWeather(city);
            return forecast.ToHistoricalWeather();
        }


        [HttpGet]
        public async Task<IEnumerable<HistoricalWeather>> GetMultiple([FromQuery(Name = "cities")] string[] cities)
        {
            var tasks = new List<Task>();
            var rows = new ConcurrentBag<HistoricalWeather>();

            void action(object city)
            {
                var c = city.ToString();
                var forecast = _service.GetHistoricalWeather(c).Result;
                var hw = forecast.ToHistoricalWeather();
                hw.City = c;
                rows.Add(hw);
            }

            foreach (var city in cities)
            {
                tasks.Add(Task.Factory.StartNew(action, city));
            }

            await Task.WhenAll(tasks.ToArray());

            return rows;
        }
    }
}
