using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherDashboard.Shared;

namespace WeatherDashboard.Server.Services
{
    public interface ILocationSearchService
    {
        Task<IEnumerable<LocationResult>> GetSearchResult(string search);
    }
}
