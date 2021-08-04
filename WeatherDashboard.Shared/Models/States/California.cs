using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDashboard.Shared.Models.States
{
    public class California : State
    {
        public California()
        {
            Name = "California";
            Cities = new City[]
            {
                new City()
                {
                    Name = "Los Angeles"
                },
                new City()
                {
                    Name = "San Diego"
                },
                new City()
                {
                    Name = "San Jose"
                },
                new City()
                {
                    Name = "San Francisco"
                },
                new City()
                {
                    Name = "Fresno"
                },
                new City()
                {
                    Name = "Sacramento"
                },
                new City()
                {
                    Name = "Long Beach"
                },
                new City()
                {
                    Name = "Oakland"
                },
                new City()
                {
                    Name = "Bakersfield"
                },
                new City()
                {
                    Name = "Anaheim"
                }
            };
        }
    }
}
