using System.Threading.Tasks;
using WeatherDashboard.Server.Services.Models;

namespace WeatherDashboard.Server.Services
{
    public interface ILocationSearchService
    {
        Task<SearchResult> GetSearchResult(string search);
    }
}
