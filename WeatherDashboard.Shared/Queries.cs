using Syncfusion.Blazor.Data;
using System.Collections.Generic;

namespace WeatherDashboard.Shared
{
    public class Queries
    {
        private static readonly List<string> _fieldNames = new() { "Name" };

        public static Query GetQuery()
        {
            return new Query().Select(_fieldNames).RequiresCount();
        }
    }
}
