using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    public GameObject collectiblePrefab; // Drag the collectible prefab here in the Unity editor
    public float spawnInterval = 1f; // The time interval between spawning new collectibles
    public Vector3 spawnArea; // The area in which collectibles can be spawned
    public int count = 0;
    private float spawnTimer;

    void Start()
    {
        spawnTimer = 0f;
    }

    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnInterval && count < 100)
        {
            // Reset the spawn timer
            spawnTimer = 0f;

            for(int i = 0; i < 100; i++)
            {
                // Generate a random position within the spawn area
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnArea.x, spawnArea.x), 13.2f, Random.Range(-spawnArea.z, spawnArea.z + 700f));

                // Instantiate the collectible prefab at the random position
                Instantiate(collectiblePrefab, spawnPosition, Quaternion.Euler(-90, 0, 0));

                count = count + 1;
            }
        }
    }
}