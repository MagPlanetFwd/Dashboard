using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherDashboard.Server.Services;
using WeatherDashboard.Shared;

namespace WeatherDashboard.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherService _service;

        public WeatherForecastController(IWeatherService weatherService)
        {
            _service = weatherService;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            var forecast = await _service.GetWeeklyForecast("Seattle");
            return Array.Empty<WeatherForecast>();
        }
    }
}
