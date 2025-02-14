using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rana : MonoBehaviour
{

    public AudioClip soundClip;   // Asigna un AudioClip desde el Inspector
    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el objeto que tocó la Berry tiene el script CharacterDash
        CharacterDash characterDash = other.GetComponent<CharacterDash>();

        if (characterDash != null)
        {

            audioSource.PlayOneShot(soundClip);
            // Destruye la fresa



       
        }
    }
}
