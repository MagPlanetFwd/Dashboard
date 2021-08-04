using System.Collections.Generic;

namespace WeatherDashboard.Shared.Models.States
{
    public class Indiana : State
    {
        public Indiana()
        {
            Name = "Indiana";
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Indianapolis"
                },
                new City()
                {
                    Name = "Fort Wayne"
                },
                new City()
                {
                    Name = " Evansville"
                },
                new City()
                {
                    Name = "South Bend"
                },
                new City()
                {
                    Name = "Carmel"
                }
            };
        }
    }
}
