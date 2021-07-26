using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
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

        public WeatherService(HttpClient httpClient, IConfiguration configuration)
        {
            _client = httpClient;
            _configuration = configuration;
        }

        public async Task<IEnumerable<Forecast>> GetWeeklyForecast(string city)
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
            return await response.Content.ReadFromJsonAsync<Forecast[]>();
        }
    }
}
