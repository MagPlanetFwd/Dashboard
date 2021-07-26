using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherDashboard.Client.ViewModels;
using WeatherDashboard.Client.Services;
using WeatherDashboard.Server.Services;

namespace WeatherDashboard.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase, IWeatherForecastController
    {
        private readonly IWeatherService _service;

        public WeatherForecastController(IWeatherService weatherService)
        {
            _service = weatherService;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherGridRow>> Get()
        {
            var tasks = new List<Task>();
            var rows = new List<WeatherGridRow>();
            var cities = new string[] { "seattle", "portland", "san francisco" };

            void action(object city)
            {
                var forecast = _service.Get3DayForecast(city.ToString()).Result;
                rows.Add(forecast.ToWeatherGridRow());
            }

            for (var i = 0; i < 3; i++)
            {
                tasks.Add(Task.Factory.StartNew(action, cities[i]));
            }

            await Task.WhenAll(tasks.ToArray());

            return rows;
        }
    }
}
