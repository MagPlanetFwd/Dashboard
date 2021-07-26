﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherDashboard.Client.Models.ViewModels;
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
            var forecast = await _service.GetWeeklyForecast("seattle");
            return forecast.ToWeatherGridRows();
        }
    }
}
