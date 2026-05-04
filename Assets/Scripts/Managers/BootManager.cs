using UnityEngine;

namespace Assets.Scripts.Managers
{
    public class BootManager : MonoBehaviour
    {
        public static BootManager Instance;

        private GameManager _GameManager;
        private TradeManager _TradeManager;
        private PlayerManager _PlayerManager;

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
        private void Start()
        {
            InitializeGameManagers();
            _GameManager.InitializePlayer();
        }

        private void InitializeGameManagers()
        {
            _GameManager = GameManager.Instance;
            _TradeManager = TradeManager.Instance;
            _PlayerManager = PlayerManager.Instance;
        }
    }
}
