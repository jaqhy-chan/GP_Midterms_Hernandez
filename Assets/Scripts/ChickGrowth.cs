using System.Collections;
using UnityEngine;

public class ChickGrowth : MonoBehaviour
{
    // Prefab for the rooster
    public GameObject roosterPrefab;

    // Prefab for the hen
    public GameObject henPrefab;

    // Timer for growth
    private float growthTimer = 0f;

    private BirdCounter birdCounter;

    void Start()
    {
        birdCounter = GameObject.FindObjectOfType<BirdCounter>();
        birdCounter.IncrementChickCount();

        growthTimer = 10f;
    }

    void Update()
    {
        // Update the growth timer
        growthTimer -= Time.deltaTime;

        // Check if it's time to grow
        if (growthTimer <= 0f)
        {
            // Grow into a rooster or hen
            GrowIntoAdult();
        }
    }

    void GrowIntoAdult()
    {
        // Check if there is only one chick
        if (GameObject.FindGameObjectsWithTag("Chick").Length == 1)
        {
            // Guarantee a hen
            GrowIntoHen();
        }
        else
        {
            // Randomly choose between rooster and hen
            if (Random.value < 0.5f)
            {
                GrowIntoRooster();
            }
            else
            {
                GrowIntoHen();
            }
        }
    }

    void GrowIntoRooster()
    {
        // Instantiate the rooster prefab
        GameObject rooster = Instantiate(roosterPrefab, transform.position, Quaternion.identity);

        birdCounter = GameObject.FindObjectOfType<BirdCounter>();
        birdCounter.DecrementChickCount();
        Destroy(gameObject);
    }

    void GrowIntoHen()
    {
        // Instantiate the hen prefab
        GameObject hen = Instantiate(henPrefab, transform.position, Quaternion.identity);

        birdCounter = GameObject.FindObjectOfType<BirdCounter>();
        birdCounter.DecrementChickCount();
        Destroy(gameObject);
    }
}