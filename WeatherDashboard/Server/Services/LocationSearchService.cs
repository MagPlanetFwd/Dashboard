﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WeatherDashboard.Server.Services.Models;

namespace WeatherDashboard.Server.Services
{
    public class LocationSearchService : ILocationSearchService
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _configuration;
        private readonly ILogger<LocationSearchService> _logger;

        public LocationSearchService(HttpClient httpClient, IConfiguration configuration, ILogger<LocationSearchService> logger)
        {
            _client = httpClient;
            _configuration = configuration;
            _logger = logger;
        }

        public async Task<SearchResult> GetLocations(string search)
        {
            try
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(_client.BaseAddress, $"search.json?q={search}"),
                    Headers = {
                        { "x-rapidapi-key", _configuration["Weather:XRapidApiKey"] },
                        { "x-rapidapi-host", "weatherapi-com.p.rapidapi.com" },
                    },
                };

                using var response = await _client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<SearchResult>();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error getting search result.");
                return new SearchResult();
            }
        }
    }
}