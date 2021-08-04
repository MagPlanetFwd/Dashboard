using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDashboard.Shared.Models.States
{
    public class Colorado : State
    {
        public Colorado()
        {
            Name = "Colorado";
            Cities = new City[]
            {
                new City()
                {
                    Name = "Denver"
                },
                new City()
                {
                    Name = "Colorado Springs"
                },
                new City()
                {
                    Name = "Aurora"
                },
                new City()
                {
                    Name = "Fort Collins"
                },
                new City()
                {
                    Name = "Lakewood"
                },
                new City()
                {
                    Name = "Thornton"
                },
                new City()
                {
                    Name = "Arvada"
                },
                new City()
                {
                    Name = "Westminster"
                },
                new City()
                {
                    Name = "Pueblo"
                },
                new City()
                {
                    Name = "Centennial"
                }
            };
        }
    }
}
