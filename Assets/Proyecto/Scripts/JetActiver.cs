using System.Collections;
using System.Collections.Generic;
using MoreMountains.CorgiEngine;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class JetActiver : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Character character = collision.GetComponent<Character>();

        if (character != null)
        {
            CharacterJetpack jetpack = character.FindAbility<CharacterJetpack>();

            if (jetpack != null)
            {
                jetpack.AbilityPermitted = true;
                AchivementManager.Logro7();
                Debug.Log("¡Jetpack desbloqueado!");

                // Llamar a MessageController para mostrar el mensaje
                if (MessageController.Instance != null)
                {
                    MessageController.Instance.ShowMessage();
                }

                Destroy(gameObject);
            }
            else
            {
                Debug.LogWarning("El jugador no tiene la habilidad CharacterJetpack.");
            }
        }
    }
}
