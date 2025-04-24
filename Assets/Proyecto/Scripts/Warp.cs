using System.Collections;
using System.Collections.Generic;
using MoreMountains.Tools;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Warp : MonoBehaviour
{
    private bool hasKey = false; // Ahora es una variable de instancia en lugar de estática

    private void Start()
    {
        hasKey = false;

        // Suscribirse al evento cuando la llave sea recogida
        Key.OnKeyCollected += UnlockDoor;
    }

    private void OnDestroy()
    {
        // Desuscribirse del evento para evitar memory leaks
        Key.OnKeyCollected -= UnlockDoor;
    }

    private void UnlockDoor()
    {
        hasKey = true; // Se activa cuando la llave es recogida
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && hasKey)
        {
            CurrentLvl.AddScore(1);

            switch (CurrentLvl.level)
            {
                case 0:
                    MMSceneLoadingManager.LoadScene("LvL1");
                    break;
                case 1:
                    AchivementManager.Logro4();
                    MMSceneLoadingManager.LoadScene("Lvl2");
                    break;
                    case 2:
                    MMSceneLoadingManager.LoadScene("Lvl3");
                    break;
                default:
                    AchivementManager.Logro5();
                    MMSceneLoadingManager.LoadScene("MainMenu");
                    break;
            }
        }
    }
}
