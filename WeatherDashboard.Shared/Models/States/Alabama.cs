namespace WeatherDashboard.Shared.Models.States
{
    public class Alabama : State
    {
        public Alabama()
        {
            Name = "Alabama";
            Cities = new City[]
            {
                new City()
                {
                    Name = "Birmingham"
                },
                new City()
                {
                    Name = "Huntsville"
                },
                new City()
                {
                    Name = "Montgomery"
                },
                new City()
                {
                    Name = "Mobile"
                },
                new City()
                {
                    Name = "Tuscaloosa"
                },
                new City()
                {
                    Name = "Hoover"
                },
                new City()
                {
                    Name = "Dothan"
                },
                new City()
                {
                    Name = "Auburn"
                },
                new City()
                {
                    Name = "Decatur"
                },
                new City()
                {
                    Name = "Madison"
                }
            };
        }
    }
}
