namespace WeatherDashboard.Shared
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
                return ForecastColor.cold;
            }
            else if(High < 15)
            {
                return ForecastColor.cool;
            }
            else if (High < 25)
            {
                return ForecastColor.average;
            }
            else if (High < 35)
            {
                return ForecastColor.warm;
            }
            else
            {
                return ForecastColor.hot;
            }
        }
    }
}
