using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Key : MonoBehaviour
{
    public static event Action OnKeyCollected; // Evento para notificar cuando la llave es recogida

    public AudioClip soundClip;
    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.PlayOneShot(soundClip);

            // Disparar el evento (si hay suscriptores)
            OnKeyCollected?.Invoke();

            // Destruir después de que termine el sonido
            Destroy(gameObject, soundClip.length);
        }
    }
}
