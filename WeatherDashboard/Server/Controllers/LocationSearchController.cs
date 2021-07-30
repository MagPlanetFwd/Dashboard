using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [HttpGet]
        public async Task<IEnumerable<string>> Get(string search)
        {
            var result = await _service.GetSearchResult(search);
            return result.LocationResults.Select(lr => lr.Name);
        }
    }
}
