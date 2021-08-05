using Microsoft.AspNetCore.Mvc;
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
        public async Task<IEnumerable<HistoricalWeather>> Get([FromQuery(Name = "city")] string city)
        {
            var forecast = await _service.GetHistoricalWeather(city);
            return forecast.ToHistoricalWeathers();
        }


    }
}
