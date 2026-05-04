using Assets.Scripts.Managers.SubManagers.Player;
using Assets.Scripts.State.PlayerState;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Scripts.Managers
{
    public class PlayerManager : MonoBehaviour
    {
        public static PlayerManager Instance;

        private InventoryManager _InventroyManager;

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
            InitializePlayerInventory();
        }
        public List<InventoryItem> GetInventoryItemsList() =>
            _InventroyManager.GetInventoryItemsList();
        private void InitializePlayerInventory()
        {
            _InventroyManager = new InventoryManager();
        }

    }
}