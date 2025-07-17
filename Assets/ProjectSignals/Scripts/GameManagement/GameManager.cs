using UnityEngine;
using UnityEngine.UI;

namespace GameManagement
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        [SerializeField] private GameObject[] nodes;
        [SerializeField] private GameObject spawnResourceButton;
        [SerializeField] private GameObject resource;

        //public delegate void SpawnResourceHandler();
        //public event SpawnResourceHandler OnSpawnResource += SpawnResource;


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
            spawnResourceButton.GetComponent<Button>().onClick.AddListener(SpawnResource);
        }

        // Update is called once per frame
        void Update()
        {

        }


        private void SpawnResource()
        {
            GameObject resourceObj;
            if(resource != null)
                resourceObj = Instantiate(resource);
        }
    }
}
