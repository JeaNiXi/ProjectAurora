using Assets.Scripts.Items;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Scripts.State.PlayerState
{
    public class InventoryState
    {
        public List<InventoryItem> InventoryItems;
        public InventoryState()
        {
            ItemSO DebugItem = new ItemSO() { Name = "Зерно" };
            InventoryItems = new List<InventoryItem>()
            {
                new InventoryItem(new Item(DebugItem),20)
            };
        }
        public List<InventoryItem> GetInventoryItemsList() =>
            InventoryItems;
    }
    public class InventoryItem
    {
        private Item _item;
        public Item Item { get { return _item; } }
        private int _amount;
        public int Amount {  get { return _amount; } }

        public InventoryItem(Item item, int amount)
        {
            _item = item;
            _amount = amount;
        }

    }

}