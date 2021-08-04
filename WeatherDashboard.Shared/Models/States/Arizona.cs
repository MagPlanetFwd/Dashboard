using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDashboard.Shared.Models.States
{
    public class Arizona : State
    {
        public Arizona()
        {
            Name = "Arizona";
            Cities = new City[]
            {
                new City()
                {
                    Name = "Phoenix"
                },
                new City()
                {
                    Name = "Tucson"
                },
                new City()
                {
                    Name = "Mesa"
                },
                new City()
                {
                    Name = "Chandler"
                },
                new City()
                {
                    Name = "Glendale"
                },
                new City()
                {
                    Name = "Scottsdale"
                },
                new City()
                {
                    Name = "Gilbert"
                },
                new City()
                {
                    Name = "Tempe"
                },
                new City()
                {
                    Name = "Peoria"
                },
                new City()
                {
                    Name = "Surprise"
                }
            };
        }
    }
}
