using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using WeatherDashboard.Client.ViewModels;
using WeatherDashboard.Server.Services;

namespace WeatherDashboard.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationSearchController : ControllerBase
    {
        private readonly ILocationSearchService _service;

        public LocationSearchController(ILocationSearchService locationSearchService)
        {
            _service = locationSearchService;
        }

        [HttpPost]
        public async Task<UrlAdapterDataManagerResult> Post(string search)
        {
            var result = await _service.GetSearchResult(search);
            return new UrlAdapterDataManagerResult()
            {
                Result = result,
                Count = result.ToArray().Length
            };
        }
    }
}
