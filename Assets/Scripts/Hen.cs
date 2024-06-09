using System.Collections;
using UnityEngine;

public class Hen : MonoBehaviour
{
    public GameObject eggPrefab; // assign your egg prefab in the inspector
    public float spawnDelay = 30f; // 30 seconds
    public float deathDelay = 40f; // 40 seconds

    private BirdCounter birdCounter;

    private void Start()
    {
        birdCounter = GameObject.FindObjectOfType<BirdCounter>();
        birdCounter.IncrementHenCount();

        Invoke("SpawnEggs", spawnDelay);
        Invoke("Die", deathDelay);
    }

    private void SpawnEggs()
    {
        int numEggs = Random.Range(2, 11); // between 2 and 10 eggs
        for (int i = 0; i < numEggs; i++)
        {
            GameObject egg = Instantiate(eggPrefab, transform.position, Quaternion.identity);
        }
    }

    private void Die()
    {
        birdCounter = GameObject.FindObjectOfType<BirdCounter>();
        birdCounter.DecrementHenCount();
        Destroy(gameObject);
    }
}