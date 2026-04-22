namespace Assets.Scripts.Items
{
    [System.Serializable]
    public class Item
    {
        public ItemSO ItemData;

        public Item(ItemSO itemData)
        {
            ItemData = itemData;
        }
    }
}
