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
            case 1:

                MMSceneLoadingManager.LoadScene("LvL1");

                return;

                default:
                MMSceneLoadingManager.LoadScene("MainMenu");


                return;

        }

   
    }

}
