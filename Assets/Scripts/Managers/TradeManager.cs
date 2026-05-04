using UnityEngine;

namespace Assets.Scripts.Managers
{
    public class TradeManager : MonoBehaviour
    {
        public static TradeManager Instance;
        private void Awake()
        {
            if (Instance != null && Instance != this)
                Destroy(gameObject);
            else
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }
        //public bool BuyTradingItem(string itemId, int cost)
        //{

        //}
    }
}