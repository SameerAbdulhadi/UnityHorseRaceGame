using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HanyFreezeTheScene : MonoBehaviour
{
    public Sprite countImage0;
    public Sprite countImage1;
    public Sprite countImage2;
    public Sprite countImage3;
    public Image CounterImage; 
    float count= 3;
    AudioSource beepSrc; 
    public AudioClip beep , siren; 
    void Start()
    {
        beepSrc = GetComponent<AudioSource>();
        beepSrc.clip = beep;
        // Call the PauseGame coroutine when the script starts
        StartCoroutine(FreezeGameForSeconds());
    }

    IEnumerator FreezeGameForSeconds()
    {
        // Pause the game  
        Time.timeScale = 0f;

        while (count >= 0)
        {

            Countdown();
            yield return new WaitForSecondsRealtime(1f);

            if (count < 0)
            {
                
                CounterImage.enabled = false;
                break;
            }
        }

       
        // Resume the game  
        Time.timeScale = 1f;
    }

    private void Countdown()
    {
        if (count == 3)
        {
            beepSrc.Play();
            CounterImage.sprite = countImage3;
        }

        if (count == 2)
        {
            beepSrc.Play();
            CounterImage.sprite = countImage2;
        }

        if (count == 1)
        {
            beepSrc.Play();
            CounterImage.sprite = countImage1;
        }

        if (count == 0)
        {
            beepSrc.clip = siren;
            beepSrc.Play();
            CounterImage.sprite = countImage0;
        }

        count--;
    }
}
