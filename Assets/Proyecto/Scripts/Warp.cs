using System.Collections;
using System.Collections.Generic;
using MoreMountains.Tools;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Warp : MonoBehaviour
{
    public static bool hasKey; 

    private void Start()
    {
        hasKey = false;
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
                    MMSceneLoadingManager.LoadScene("Lvl2");
                    break;
                default:
                    MMSceneLoadingManager.LoadScene("MainMenu");
                    break;

            }

        
        }
    }
}
