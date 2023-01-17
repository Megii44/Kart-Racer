using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    public GameObject collectiblePrefab; // Drag the collectible prefab here in the Unity editor
    public float spawnInterval = 1f; // The time interval between spawning new collectibles
    public int x1; // The area in which collectibles can be spawned
    public int x2;
    public int z1;
    public int z2;
    public int x1_; // The area in which collectibles can be spawned
    public int x2_;
    public int z1_;
    public int z2_;
    public int x1__; // The area in which collectibles can be spawned
    public int x2__;
    public int z1__;
    public int z2__;
    private int count = 0;
    private float spawnTimer;

    void Start()
    {
        spawnTimer = 0f;
    }

    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnInterval && count < 21)
        {
            // Reset the spawn timer
            spawnTimer = 0f;

            for(int i = 0; i < 21; i++)
            {

                Vector3 spawnPosition = new Vector3(Random.Range(x1, x2), 13.2f, Random.Range(z1, z2));

                if (i % 3 == 1)
                    spawnPosition = new Vector3(Random.Range(x1_, x2_), 13.2f, Random.Range(z1_, z2_));
                if (i % 3 == 2)
                    spawnPosition = new Vector3(Random.Range(x1__, x2__), 13.2f, Random.Range(z1__, z2__));
                
                // Instantiate the collectible prefab at the random position
                Instantiate(collectiblePrefab, spawnPosition, Quaternion.Euler(-90, 0, 0));

                count = count + 1;
            }
        }
    }
}