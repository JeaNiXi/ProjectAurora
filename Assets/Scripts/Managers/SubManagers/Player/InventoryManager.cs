using Assets.Scripts.State.PlayerState;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Managers.SubManagers.Player
{
    public class InventoryManager
    {
        private InventoryState _InventoryState;
        public InventoryManager()
        {
            _InventoryState = new InventoryState();
        }
        public List<InventoryItem> GetInventoryItemsList() =>
            _InventoryState.GetInventoryItemsList();
    }
}