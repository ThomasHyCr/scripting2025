using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.CorgiEngine;
using UnityEngine.UI;
using System;

public class MenuManager : MonoBehaviour
{
    
    //private static MMAchievement _achievement = null;

    [SerializeField]
    private List<GameObject> imgLogrosLista;

    public static bool[] estadoLogros= new bool[10];  


    public GameObject creditsP;
    public GameObject instructionsP;
    public GameObject creditsB;
    public GameObject instructionsB;
    public GameObject exitB;
    public GameObject mainP;
    public GameObject achivP;
    public GameObject achivB;

    public AudioSource audioSource; // Asigna un AudioSource desde el Inspector
    public AudioClip soundClip;   // Asigna un AudioClip desde el Inspector
   
    public static void CargaLogros(bool[] estado,List<GameObject> imgLogrosLista2)
    {
        for(int i = 0; i<10; i++)
        {
            
            if (estado[i])
            {

                imgLogrosLista2[i].GetComponent<Image>().color = new Color(255, 255, 255, 1);

            }
            else
            {
                imgLogrosLista2[i].GetComponent<Image>().color = new Color(255, 255, 255, 0.5f);
            }

        }
 
    }


    // Start is called before the first frame update
    void Start()
    {
        CurrentLvl.level = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AbreMenuIns()
    {
        instructionsP.SetActive(true);
        mainP.SetActive(false);
    }

    public void AbreMenuCred() 
    {
        creditsP.SetActive(true);
        mainP.SetActive(false);
    }

    public void AbreMenuAchiv()
    {
        achivP.SetActive(true);
        mainP.SetActive(false);
        CargaLogros(estadoLogros,imgLogrosLista);

    }
    public void CierraMenuAchiv()
    {
        achivP.SetActive(false);
        mainP.SetActive(true);
    }

    public void CerrarMenuCred()
    {
        mainP.SetActive(true);
        creditsP.SetActive(false);
        
    }

    public void CerrarMenuIns()
    {
        mainP.SetActive(true);
        instructionsP.SetActive(false);
    }

    public void CargaScene()
    {
        MMSceneLoadingManager.LoadScene("DifficultySelector");
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }

    public void Rana() {

        audioSource.PlayOneShot(soundClip);
    }

    public void ResetearLogros()
    {
        MMAchievementManager.ResetAchievements("AchievementsList");
        for (int i = 0; i < 10; i++)
        {
            estadoLogros[i] = false;
        }

    }
}
