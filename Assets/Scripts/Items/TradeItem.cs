namespace Assets.Scripts.Items
{
    [System.Serializable]
    public class TradeItem
    {
        public Item Item;
        public int Amount;
        public TradeItem(Item item, int amount)
        {
            Item = item;
            Amount = amount;
        }
    }
}
