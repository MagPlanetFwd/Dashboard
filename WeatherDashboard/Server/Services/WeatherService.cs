using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WeatherDashboard.Server.Services.Models;

namespace WeatherDashboard.Server.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;

        public WeatherService(HttpClient httpClient, IConfiguration configuration, ILogger<WeatherService> logger)
        {
            _client = httpClient;
            _configuration = configuration;
            _logger = logger;
        }

        public async Task<WeatherForecast> GetWeeklyForecast(string city)
        {
            try
            {
                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri(_client.BaseAddress, $"forecast.json?q={city}&days=7"),
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
            catch(Exception e)
            {
                _logger.LogError(e, "Error getting weekly forecast");
                return new WeatherForecast();
            }
        }
    }
}
