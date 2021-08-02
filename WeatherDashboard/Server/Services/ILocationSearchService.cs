using System.Threading.Tasks;
using WeatherDashboard.Shared;

namespace WeatherDashboard.Server.Services
{
    public interface ILocationSearchService
    {
        Task<LocationResult[]> GetSearchResult(string search);
    }
}
