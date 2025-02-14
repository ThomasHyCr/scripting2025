using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject creditsP;
    public GameObject instructionsP;
    public GameObject creditsB;
    public GameObject instructionsB;
    public GameObject exitB;
    public GameObject mainP;
    /*
    public GameObject backBI;
    public GameObject backBC;*/

    // Start is called before the first frame update
    void Start()
    {

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
        MMSceneLoadingManager.LoadScene("LvL1");
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }
}
