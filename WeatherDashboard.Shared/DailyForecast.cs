namespace WeatherDashboard.Shared
{
    public class DailyForecast
    {
        public float Low { get; set; }
        public float High { get; set; }
        public string Icon { get; set; }

        public override string ToString()
        {
            return $"{High} / {Low}";
        }
    }
}
