namespace WeatherDashboard.Shared.Models
{
    public class DailyForecast
    {
        public float Low { get; set; }
        public float High { get; set; }
        public string Icon { get; set; }
        public ForecastColor Color 
        { 
            get 
            {
                return GetForecastColor();
            } 
        }

        public override string ToString()
        {
            return $"{High} / {Low}";
        }

        private ForecastColor GetForecastColor()
        {
            if(High < 5)
            {
                return ForecastColor.Cold;
            }
            else if(High < 15)
            {
                return ForecastColor.Cool;
            }
            else if (High < 25)
            {
                return ForecastColor.Average;
            }
            else if (High < 35)
            {
                return ForecastColor.Warm;
            }
            else
            {
                return ForecastColor.Hot;
            }
        }
    }
}
