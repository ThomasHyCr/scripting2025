using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.CorgiEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class MenuManager : MonoBehaviour
{
    
    //private static MMAchievement _achievement = null;

    [SerializeField]
    private List<GameObject> imgLogrosLista;

    public static bool[] estadoLogros= new bool[10];


    [SerializeField] private TextMeshProUGUI text7;
    [SerializeField] private TextMeshProUGUI text8;
    [SerializeField] private TextMeshProUGUI text9;

    [SerializeField] private GameObject egg1;
    [SerializeField] private GameObject egg2;
    [SerializeField] private GameObject egg3;

    [SerializeField] private GameObject creditsP;
    [SerializeField] private GameObject instructionsP;
    [SerializeField] private GameObject creditsB;
    [SerializeField] private GameObject instructionsB;
    [SerializeField] private GameObject exitB;
    [SerializeField] private GameObject mainP;
    [SerializeField] private GameObject achivP;
    [SerializeField] private GameObject achivB;

    [SerializeField] private AudioSource audioSource; // Asigna un AudioSource desde el Inspector
    [SerializeField] private AudioClip soundClip;   // Asigna un AudioClip desde el Inspector
   
    public void CargaLogros(bool[] estado,List<GameObject> imgLogrosLista2)
    {
        for(int i = 0; i<10; i++)
        {
            
            if (estado[i])
            {

                imgLogrosLista2[i].GetComponent<Image>().color = new Color(255, 255, 255, 1);
          


                    switch (i) 
                {

                    case 7:


                      egg1.SetActive(true);
                    text7.text = "Encuentra el Easter Egg en el primer nivel";

                        break;

                    case 8:
                        egg2.SetActive(true);
                        text8.text = "Encuentra el Easter Egg en el segundo nivel";

                        break;

                    case 9:
                        egg3.SetActive(true);
                        text9.text = "Encuentra el Easter Egg en el tercer nivel";

                        break;


                }

                
            }
            else
            {
                imgLogrosLista2[i].GetComponent<Image>().color = new Color(255, 255, 255, 0.5f);

                switch (i)
                {

                    case 7:
                        egg1.SetActive(false);
                        text7.text = "Logro oculto";

                        break;

                    case 8:
                        egg2.SetActive(false);
                        text8.text = "Logro oculto";

                        break;

                    case 9:

                        egg3.SetActive(false);
                        text9.text = "Logro oculto";

                        break;


                }

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

        ResetearLogros();
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

        CargaLogros(estadoLogros, imgLogrosLista);
        MMAchievementManager.ResetAchievements("AchievementsList");
        for (int i = 0; i < 10; i++)
        {
            estadoLogros[i] = false;
        }

    }
}
