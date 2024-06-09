using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BirdCounter : MonoBehaviour
{
    public TextMeshProUGUI chickCountText;
    public TextMeshProUGUI henCountText;
    public TextMeshProUGUI roosterCountText;

    private int chickCount = 0;
    private int henCount = 0;
    private int roosterCount = 0;

    void Start()
    {
        // Initialize the text components
        chickCountText.text = "Chicks: 0";
        henCountText.text = "Hens: 0";
        roosterCountText.text = "Roosters: 0";
    }

    public void IncrementChickCount()
    {
        chickCount++;
        chickCountText.text = "Chicks: " + chickCount;
    }

    public void IncrementHenCount()
    {
        henCount++;
        henCountText.text = "Hens: " + henCount;
    }

    public void IncrementRoosterCount()
    {
        roosterCount++;
        roosterCountText.text = "Roosters: " + roosterCount;
    }

    public void DecrementChickCount()
    {
        chickCount--;
        chickCountText.text = "Chicks: " + chickCount;
    }

    public void DecrementHenCount()
    {
        henCount--;
        henCountText.text = "Hens: " + henCount;
    }

    public void DecrementRoosterCount()
    {
        roosterCount--;
        roosterCountText.text = "Roosters: " + roosterCount;
    }
}