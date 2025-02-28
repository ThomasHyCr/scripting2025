using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rana : MonoBehaviour
{

    public AudioClip soundClip;   // Asigna un AudioClip desde el Inspector
    public AudioSource audioSource;

    private MMPathMovement trayectoria;
    private bool isFalling = false;
    private float rotationSpeed = 50f; // Velocidad de rotaci�n

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el objeto que toc� la rana tiene el script CharacterDash
        CharacterDash characterDash = other.GetComponent<CharacterDash>();

        if (characterDash != null)
        {
            audioSource.PlayOneShot(soundClip);

            trayectoria = GetComponent<MMPathMovement>();
            trayectoria.enabled = true;
            isFalling = true; // Activa la rotaci�n
        }
    }

    private void Update()
    {
        if (isFalling)
        {
            // Rota en el eje Y mientras desciende
            transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);
        }
    }
}
