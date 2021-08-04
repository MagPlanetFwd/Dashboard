using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDashboard.Shared.Models.States
{
    public class Arkansas : State
    {
        public Arkansas()
        {
            Name = "Arkansas";
            Cities = new City[]
            {
                new City()
                {
                    Name = "Little Rock"
                },
                new City()
                {
                    Name = "Fort Smith"
                },
                new City()
                {
                    Name = "Fayetteville"
                },
                new City()
                {
                    Name = "Springdale"
                },
                new City()
                {
                    Name = "Jonesboro"
                },
                new City()
                {
                    Name = "Rogers"
                },
                new City()
                {
                    Name = "North Little Rock"
                },
                new City()
                {
                    Name = "Conway"
                },
                new City()
                {
                    Name = "Bentonville"
                },
                new City()
                {
                    Name = "Pine Bluff"
                }
            };
        }
    }
}
