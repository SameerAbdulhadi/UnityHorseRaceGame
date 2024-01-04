using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanyPowerHeal : MonoBehaviour
{
 
    float duration = 3f;
    AudioSource src;
    bool doneCoroutine = false;
    GameObject[] obstacles;
    VolcanoMapInputSystem inputscript; 
    private void Start()
    {
        src = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        inputscript = other.GetComponent<VolcanoMapInputSystem>();

        if (other.tag == "Horse")
        {
            src.Play();
            if(inputscript.horseLives<5)
            {
                inputscript.horseLives++; 
                RecoverImage();
            }
        }
    }


    private void RecoverImage()
    {
        if(inputscript.horseLives==5)
        {
            inputscript.playerLivesImages.transform.GetChild(4).gameObject.SetActive(true);
        }

        if (inputscript.horseLives == 4)
        {
            inputscript.playerLivesImages.transform.GetChild(3).gameObject.SetActive(true);
        }

        if (inputscript.horseLives == 3)
        {
            inputscript.playerLivesImages.transform.GetChild(2).gameObject.SetActive(true);
        }

        if (inputscript.horseLives == 2)
        {
            inputscript.playerLivesImages.transform.GetChild(1).gameObject.SetActive(true);
        }

        if (inputscript.horseLives == 1)
        {
            inputscript.playerLivesImages.transform.GetChild(0).gameObject.SetActive(true);
        }

    }
}
