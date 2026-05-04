using Assets.Scripts.State.PlayerState;
using UnityEngine;
namespace Assets.Scripts.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

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

        public void InitializePlayer()
        {
            PlayerManager.Instance.InitializePlayer();
            var inventoryList = PlayerManager.Instance.GetInventoryItemsList();
            var number = 1;
            foreach (InventoryItem inventory in inventoryList)
            {
                Debug.Log($"Предмет в трюме корабля №[{number}]: {inventory.Item.ItemData.Name}, {inventory.Amount} шт.");
            }
        }
    }
}