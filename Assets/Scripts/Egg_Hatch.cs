using System.Collections;
using UnityEngine;

public class EggHatch : MonoBehaviour
{
    public GameObject chickPrefab; // assign your chick prefab in the inspector
    public float hatchDelay = 10f; // 10 seconds

    private BirdCounter birdCounter;

    private void Start()
    {
        birdCounter = GameObject.FindObjectOfType<BirdCounter>();
        birdCounter.DecrementChickCount();
        birdCounter.IncrementChickCount();

        Invoke("Hatch", hatchDelay);
    }

    private void Hatch()
    {
        // Destroy the egg game object
        Destroy(gameObject);

        // Instantiate a new chick at the same position
        GameObject chick = Instantiate(chickPrefab, transform.position, Quaternion.identity);
    }
}