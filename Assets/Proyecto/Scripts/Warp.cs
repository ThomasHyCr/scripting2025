using System.Collections;
using System.Collections.Generic;
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
            SceneManager.LoadScene("LvL1"); // Cargar la siguiente escena
        }
    }
}
