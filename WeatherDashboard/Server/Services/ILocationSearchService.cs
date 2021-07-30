using System.Threading.Tasks;
using WeatherDashboard.Server.Services.Models;

namespace WeatherDashboard.Server.Services
{
    interface ILocationSearchService
    {
        Task<SearchResult> GetLocations(string search);
    }
}
