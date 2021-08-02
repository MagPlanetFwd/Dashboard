using Microsoft.AspNetCore.Mvc;
using Syncfusion.Blazor.Data;
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

        [HttpPost]
        public async Task<DataResult> Post(string search)
        {
            var result = await _service.GetSearchResult(search);
            return new DataResult()
            {
                Result = result,
                Count = result.Length
            };
        }
    }
}
