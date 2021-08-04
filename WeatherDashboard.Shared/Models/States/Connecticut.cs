using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDashboard.Shared.Models.States
{
    public class Connecticut : State
    {
        public Connecticut()
        {
            Name = "Connecticut";
            Cities = new City[]
            {
                new City()
                {
                    Name = "Bridgeport"
                },
                new City()
                {
                    Name = "New Haven"
                },
                new City()
                {
                    Name = "Stamford"
                },
                new City()
                {
                    Name = "Hartford"
                },
                new City()
                {
                    Name = "Waterbury"
                },
                new City()
                {
                    Name = "Norwalk"
                },
                new City()
                {
                    Name = "Danbury"
                },
                new City()
                {
                    Name = "New Britain"
                },
                new City()
                {
                    Name = "Bristol"
                },
                new City()
                {
                    Name = "Meriden"
                }
            };
        }
    }
}
