using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Celestial
{
    [CreateAssetMenu(fileName = "Star System", menuName = "Scriptable Object/Celestial/Star System")]
    public class StarSystem : ScriptableObject
    {
        [Header("Main Info")]
        [field: SerializeField] public string SystemID { get; set; }
        [field: SerializeField] public string SystemName { get; set; }

        [Header("System Metadata")]
        [TextArea]
        [field: SerializeField] public string SystemDescription { get; set; }

        [Header("Visual")]
        [field: SerializeField] public Sprite SystemBackground { get; set; }

        [Header("Celestial Objects")]
        [field: SerializeField] public List<PlanetPositionData> SystemPlanetList = new List<PlanetPositionData>();
        
    }
    [System.Serializable]
    public struct PlanetPositionData
    {
        public string PlanetName;
        public Vector2 PlanetPosition;
        public GameObject PlanetPrefab;
    }
}
