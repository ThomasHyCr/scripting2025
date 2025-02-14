using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchToggle : MonoBehaviour
{
    public List<GameObject> redBlocks;
    public List<GameObject> blueBlocks;

    private bool isRedActive = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Asegúrate de que el jugador tiene el tag "Player"
        {
            ToggleBlocks();
        }
    }

    private void ToggleBlocks()
    {
        isRedActive = !isRedActive;

        foreach (GameObject red in redBlocks)
        {
            red.SetActive(isRedActive);
        }

        foreach (GameObject blue in blueBlocks)
        {
            blue.SetActive(!isRedActive);
        }
    }
}
