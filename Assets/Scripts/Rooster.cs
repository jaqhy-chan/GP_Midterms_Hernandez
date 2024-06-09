using System.Collections;
using UnityEngine;

public class Rooster : MonoBehaviour
{
    public float deathDelay = 40f; // 40 seconds

    private BirdCounter birdCounter;

    private void Start()
    {
        birdCounter = GameObject.FindObjectOfType<BirdCounter>();
        birdCounter.IncrementRoosterCount();

        Invoke("Die", deathDelay);
    }

    private void Die()
    {
        birdCounter = GameObject.FindObjectOfType<BirdCounter>();
        birdCounter.DecrementRoosterCount();
        Destroy(gameObject);
    }
}