using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageController : MonoBehaviour
{
    public AudioClip soundClip;    
    public AudioClip soundClip2;    
    public AudioSource audioSource;

    public static MessageController Instance;

    public GameObject messagePowerup;
    public GameObject messagePowerup2;  
    public GameObject messageSign;

    [SerializeField] public bool isJetPower;  

    private void Awake()
    {
        Instance = this;
    }

    public void ShowMessage()
    {
        GameObject selectedMessage = isJetPower ? messagePowerup2 : messagePowerup;

        if (selectedMessage != null)
        {
            audioSource.PlayOneShot(soundClip);
            selectedMessage.SetActive(true);
            StartCoroutine(HideMessageAfterDelay(selectedMessage, 3f));
        }
    }

    private IEnumerator HideMessageAfterDelay(GameObject message, float delay)
    {
        yield return new WaitForSeconds(delay);
        if (message != null)
        {
            message.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        audioSource.PlayOneShot(soundClip2);
        messageSign.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        messageSign.SetActive(false);
    }
}
