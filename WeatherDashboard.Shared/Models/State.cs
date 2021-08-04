using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models
{
    public class State : INamed
    {
        public string Name { get; set; }

        public IEnumerable<City> Cities { get; set; }
    }
}
