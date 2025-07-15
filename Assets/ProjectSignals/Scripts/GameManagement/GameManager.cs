using UnityEngine;

namespace GameManagement
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        [SerializeField] private GameObject[] nodes;
        [SerializeField] private GameObject resource;

        public delegate void SpawnResourceHandler();
        public event SpawnResourceHandler OnSpawnResource = delegate { SpawnResource(); };


        private void Awake()
        {
            // Singleton Pattern
            if (Instance != null && Instance != this)
            {
                Destroy(this);
            }
            else
            {
                Instance = this;
            }
        }

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }


        private static void SpawnResource()
        {
            GameObject resource = Instantiate(resource);
        }
    }
}
