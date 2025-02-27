using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOverManager : MonoBehaviour
{
        
    

    public void Volver()
    {

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
