namespace WeatherDashboard.Shared.Models.States
{
    public class Alaska : State
    {
        public Alaska()
        {
            Name = "Alaska";
            Cities = new City[]
            {
                new City()
                {
                    Name = "Anchorage"
                },
                new City()
                {
                    Name = "Fairbanks"
                },
                new City()
                {
                    Name = "Juneau"
                },
                new City()
                {
                    Name = "Sitka"
                },
                new City()
                {
                    Name = "Ketchikan"
                },
                new City()
                {
                    Name = "Wasilla"
                },
                new City()
                {
                    Name = "Kenai"
                },
                new City()
                {
                    Name = "Kodiak"
                },
                new City()
                {
                    Name = "Bethel"
                },
                new City()
                {
                    Name = "Palmer"
                }
            };
        }
    }
}
