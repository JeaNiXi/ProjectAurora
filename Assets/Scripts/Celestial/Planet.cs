using Assets.Scripts.Items;
using System.Collections.Generic;

namespace Assets.Scripts.Celestial
{
    public class Planet : CelestialBody
    {
        public string ID { get; private set; }
        public PlanetSO PlanetData { get; private set; }
        public List<TradeItem> TradeItemsList { get; private set; }

        public Planet(PlanetSO planetData)
        {
            TradeItemsList= new List<TradeItem>();
            ID = planetData.ID;
            PlanetData = planetData;
            TradeItemsList= PlanetData.TradeItems;
        }
    }
}