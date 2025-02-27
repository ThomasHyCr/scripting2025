using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class CoinDoorUnlock : MonoBehaviour, MMEventListener<PickableItemEvent>
{
    int contadorMonedas = 0;

    [SerializeField]
    private GameObject paredDesbloqueable1;
    [SerializeField]
    private GameObject paredDesbloqueable2;

    Color paredDesbloqueada;

    void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }
    void OnDisable()
    {
        this.MMEventStopListening<PickableItemEvent>();
    }

    public virtual void OnMMEvent(PickableItemEvent e)
    {
        Coin coin = e.PickedItem.GetComponent<Coin>();

        if (coin != null)
        {
            contadorMonedas++;
        }

        if(contadorMonedas == 10)
        {
            paredDesbloqueable1.GetComponent<BoxCollider2D>().enabled = false;
            paredDesbloqueable1.GetComponent <SpriteRenderer>().enabled = false;

            paredDesbloqueable2.GetComponent<BoxCollider2D>().enabled = false;
            paredDesbloqueable2.GetComponent<SpriteRenderer>().enabled = false;

        }


    }
}
