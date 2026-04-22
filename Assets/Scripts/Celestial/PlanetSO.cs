using Assets.Scripts.Items;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Scripts.Celestial
{
    [CreateAssetMenu(fileName = "Planet", menuName = "Scriptable Object/Celestial/PlanetSO")]
    public class PlanetSO : ScriptableObject
    {
        [Header("Main Info")]
        [field: SerializeField] public string ID {  get; set; }
        [field: SerializeField] public string Name { get; set; }
        [Header("Trade Items")]
        public List<TradeItem> TradeItems = new();
    }
}