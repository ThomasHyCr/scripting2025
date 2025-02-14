using System.Collections;
using System.Collections.Generic;
using MoreMountains.CorgiEngine;
using UnityEngine;

public class berry : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el objeto que tocó la Berry tiene el script CharacterDash
        CharacterDash characterDash = other.GetComponent<CharacterDash>();

        if (characterDash != null)
        {
            // Activa la habilidad de Dash
            characterDash.DashDistance = 5f;

            // Destruye la fresa
            Destroy(gameObject);
        }
    }
}
