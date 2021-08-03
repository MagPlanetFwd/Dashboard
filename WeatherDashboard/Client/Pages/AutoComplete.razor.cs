using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor.Data;
using WeatherDashboard.Client.Data;

namespace WeatherDashboard.Client.Pages
{
    public class AutoCompleteBase : ComponentBase
    {
        protected string SearchBox { get; set; }

        protected static Query GetQuery()
        {
            return Queries.GetQuery();
        }

        protected string GetSearchUrl()
        {
            return $"https://localhost:5001/LocationSearch?search={SearchBox}";
        }

        protected void OnAutoCompleteKeyPressed(KeyboardEventArgs args)
        {
            SearchBox += args.Key;
        }

        protected void OnAutoCompleteKeyDown(KeyboardEventArgs args)
        {
            if (args.Code == "Backspace" && SearchBox.Length > 0)
            {
                SearchBox = SearchBox.Remove(SearchBox.Length - 1);
            }
        }
    }
}
