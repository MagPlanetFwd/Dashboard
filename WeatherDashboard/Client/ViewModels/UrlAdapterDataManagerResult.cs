using System.Collections.Generic;
using WeatherDashboard.Shared;

namespace WeatherDashboard.Client.ViewModels
{
    public class UrlAdapterDataManagerResult
    {
        public IEnumerable<LocationResult> Result { get; set; }
        public int Count { get; set; }
    }
}
