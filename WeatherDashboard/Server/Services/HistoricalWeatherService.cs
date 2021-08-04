using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WeatherDashboard.Server.Services.Models;

namespace WeatherDashboard.Server.Services
{
    public class HistoricalWeatherService : IHistoricalWeatherService
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _configuration;
        private readonly ILogger<HistoricalWeatherService> _logger;

        public HistoricalWeatherService(HttpClient httpClient, IConfiguration configuration, ILogger<HistoricalWeatherService> logger)
        {
            _client = httpClient;
            _configuration = configuration;
            _logger = logger;
        }

        public async Task<WeatherForecast> GetHistoricalWeather(string city)
        {
            try
            {
                var dtFormat = ("yyyy-MM-dd");
                var dt = DateTime.Today.AddDays(-7).ToString(dtFormat);
                var endDt = DateTime.Today.AddDays(-1).ToString(dtFormat);
                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri(_client.BaseAddress, $"history.json?q={city}&dt={dt}&end_dt={endDt}"),
                    Method = HttpMethod.Get,
                    Headers = {
                        { "x-rapidapi-key", _configuration["Weather:XRapidApiKey"] },
                        { "x-rapidapi-host", "weatherapi-com.p.rapidapi.com" },
                    },
                };
                using var response = await _client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var forecasts = await response.Content.ReadFromJsonAsync<WeatherForecast>();
                return forecasts;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error getting weekly forecast");
                return new WeatherForecast();
            }
        }
    }
}
