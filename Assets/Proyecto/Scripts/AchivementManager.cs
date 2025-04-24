using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
using UnityEngine.UI;

public class AchivementManager : MonoBehaviour, MMEventListener<PickableItemEvent>, MMEventListener<MMCharacterEvent>
{
    int contamoneda;

    void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
        this.MMEventStartListening<MMCharacterEvent>();
    }
    void OnDisable()
    {
        this.MMEventStopListening<PickableItemEvent>();
        this.MMEventStopListening<MMCharacterEvent>();
    }

    public virtual void OnMMEvent(PickableItemEvent pickableItemEvent)
    {
        Debug.Log("Aeeeeeeeeeeeeeeeee");
        Coin coin = pickableItemEvent.PickedItem.GetComponent<Coin>();

        if (coin != null)
        {  
                Logro2();
                Logro3();
                Debug.Log("AAAAAAAAAAAAA");

            
        }
    }

    public virtual void OnMMEvent(MMCharacterEvent characterEvent)
    {
        if (characterEvent.TargetCharacter.CharacterType == Character.CharacterTypes.Player)
        {
            switch (characterEvent.EventType)
            {
                case MMCharacterEventTypes.Jump:
                    MMAchievementManager.UnlockAchievement("ElComienzo");
                    MenuManager.estadoLogros[0] = true;
                    break;
            }
        }
    }



    public void Logro2()
    {
        MMAchievementManager.UnlockAchievement("Ay");
        MenuManager.estadoLogros[1] = true;
    }

    public void Logro3()
    {
        MMAchievementManager.AddProgress("10Libros", 1);
        contamoneda++;
        if (contamoneda == 10)
        {
            MenuManager.estadoLogros[2] = true;
        }
    }

    public static void Logro4()
    {
        MMAchievementManager.UnlockAchievement("NivelHard");
        MenuManager.estadoLogros[3] = true;
    }

    public static void Logro5()
    {
        MMAchievementManager.UnlockAchievement("JuegoHard");
        MenuManager.estadoLogros[4] = true;
    }

    public static void Logro6()
    {
        MMAchievementManager.UnlockAchievement("PwUp1");
        MenuManager.estadoLogros[5] = true;
    }

    public static void Logro7()
    {
        MMAchievementManager.UnlockAchievement("PwUp2");
        MenuManager.estadoLogros[6] = true;
    }

    public static void Logro8()
    {
        MMAchievementManager.UnlockAchievement("Egg1");
        MenuManager.estadoLogros[7] = true;
    }

    public static void Logro9()
    {
        MMAchievementManager.UnlockAchievement("Egg2");
        MenuManager.estadoLogros[8] = true;
    }

    public static void Logro10()
    {
        MMAchievementManager.UnlockAchievement("Egg3");
        MenuManager.estadoLogros[9] = true;
    }
}
