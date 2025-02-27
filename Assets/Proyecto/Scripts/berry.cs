using System.Collections;
using System.Collections.Generic;
using MoreMountains.CorgiEngine;
using UnityEngine;

public class Berry : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el objeto que entró en contacto es un personaje
        Character character = other.GetComponent<Character>();

        

        if (character != null)
        {
            // Busca la habilidad CharacterDash en el jugador
            CharacterDash dash = character.FindAbility<CharacterDash>();

            if (dash != null)
            {
                dash.AbilityPermitted = true;
                Debug.Log("¡Dash desbloqueado!");

                // Llamar a MessageController para mostrar el mensaje
                if (CurrentLvl.level == 0 && MessageController.Instance != null)
                {
                    MessageController.Instance.ShowMessage();
                }

                Destroy(gameObject); // Se destruye después de ser recogida
            }
            else
            {
                Debug.LogWarning("El jugador no tiene la habilidad CharacterDash.");
            }
        }
    }
}
