using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using WeatherDashboard.Shared.Models;

namespace WeatherDashboard.Components
{
    public class LocalAutoCompleteBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<INamed> NamedSources { get; set; }

        protected IEnumerable<string> GetSource()
        {
            return NamedSources.Select(n => n.Name);
        }
    }
}
