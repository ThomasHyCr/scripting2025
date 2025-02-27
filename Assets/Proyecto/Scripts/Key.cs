using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public AudioClip soundClip;   // Asigna un AudioClip desde el Inspector
    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.PlayOneShot(soundClip);
            Warp.hasKey = true; // Activa la llave en la puerta

            // Destruir después de que termine el sonido
            Destroy(gameObject, soundClip.length);
        }
    }
}
