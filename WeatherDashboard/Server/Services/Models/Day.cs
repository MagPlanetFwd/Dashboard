namespace WeatherDashboard.Server.Services.Models
{
    public class Day
    {
        public float Mintemp_c { get; set; }
        public float Maxtemp_c { get; set; }
        public Condition Condition { get; set; }

    }
}
