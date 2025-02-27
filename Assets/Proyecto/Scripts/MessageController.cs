using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageController : MonoBehaviour
{

    public AudioClip soundClip;   // Asigna un AudioClip desde el Inspector
    public AudioClip soundClip2;   // Asigna un AudioClip desde el Inspector
    public AudioSource audioSource;

    public static MessageController Instance;
    public GameObject messagePowerup;
    public GameObject messageSign;

    private void Awake()
    {
        Instance = this;
    }

    public void ShowMessage()
    {
        if (messagePowerup != null)
        {
            audioSource.PlayOneShot(soundClip);

            messagePowerup.SetActive(true);
            StartCoroutine(HideMessageAfterDelay(3f));
        }
    }

    private IEnumerator HideMessageAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        if (messagePowerup != null)
        {
            messagePowerup.SetActive(false);
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
