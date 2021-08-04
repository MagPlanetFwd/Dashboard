using System.Collections.Generic;
using WeatherDashboard.Shared.Models;
using WeatherDashboard.Shared.Models.States;

namespace WeatherDashboard.Client.Services
{
    public class LocationsProvider
    {
        private readonly State[] _states;

        public LocationsProvider()
        {
            _states = new State[]
            {
                new Alabama(),
                new Alaska(),
                new Arizona(),
                new Arkansas(),
                new California(),
                new Colorado(),
                new Connecticut(),
                new Delaware(),
                new Florida(),
                new Georgia(),
                new Hawaii(),
                new Idaho(),
                new Illinois(),
                new Indiana(),
                new Iowa(),
                new Kansas(),
                new Kentucky(),
                new Louisiana(),
                new Maine(),
                new Maryland(),
                new Massachusetts(),
                new Michigan(),
                new Minnesota(),
                new Mississippi(),
                new Missouri(),
                new Montana(),
                new Nebraska(),
                new Nevada(),
                new NewHampshire(),
                new NewJersey(),
                new NewMexico(),
                new NewYork(),
                new NorthCarolina(),
                new NorthDakota(),
                new Ohio(),
                new Oklahoma(),
                new Oregon(),
                new Pennsylvania(),
                new RhodeIsland(),
                new SouthCarolina(),
                new SouthDakota(),
                new Tennessee(),
                new Texas(),
                new Utah(),
                new Vermont(),
                new Virginia(),
                new Washington(),
                new WestVirginia(),
                new Wisconsin(),
                new Wyoming()
            };
        }

        public IEnumerable<State> GetStates()
        {
            return _states;
        }
    }
}
