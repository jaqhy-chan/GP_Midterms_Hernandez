using System.Collections;
using UnityEngine;

public class EggSpawn : MonoBehaviour
{
    public GameObject eggPrefab; // assign your egg prefab in the inspector

    private void Start()
    {
        SpawnEgg();
    }

    private void SpawnEgg()
    {
        GameObject egg = Instantiate(eggPrefab, transform.position, Quaternion.identity);
    }
}