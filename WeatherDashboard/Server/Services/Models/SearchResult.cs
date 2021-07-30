using System.Collections.Generic;

namespace WeatherDashboard.Server.Services.Models
{
    public class SearchResult
    {
        public IEnumerable<LocationResult> LocationResults { get; set; }
    }
}
