using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor.Data;
using WeatherDashboard.Client.Data;

namespace WeatherDashboard.Client.Pages
{
    public class RemoteAutoCompleteBase : ComponentBase
    {
        protected string RemoteSearch { get; set; }

        protected static Query GetQuery()
        {
            return Queries.GetQuery();
        }

        protected string GetSearchUrl()
        {
            return $"https://localhost:5001/LocationSearch?search={RemoteSearch}";
        }

        protected void OnAutoCompleteKeyPressed(KeyboardEventArgs args)
        {
            RemoteSearch += args.Key;
        }

        protected void OnAutoCompleteKeyDown(KeyboardEventArgs args)
        {
            if (args.Code == "Backspace" && RemoteSearch.Length > 0)
            {
                RemoteSearch = RemoteSearch.Remove(RemoteSearch.Length - 1);
            }
        }
    }
}
