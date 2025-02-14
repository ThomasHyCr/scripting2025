using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Warp.hasKey = true; // Activa la llave en la puerta
            Destroy(gameObject); // Destruye la llave
        }
    }
}
