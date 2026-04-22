using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Items
{
    [CreateAssetMenu(fileName = "Item", menuName = "Scriptable Object/Items/Item")]
    public class ItemSO : ScriptableObject
    {
        [Header("Main Info")]
        [field: SerializeField] public string Name { get; set; }
    }
}
