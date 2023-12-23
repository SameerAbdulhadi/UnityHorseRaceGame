using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanyHorseSoundEffects : MonoBehaviour
{
    public AudioSource src1;

    public AudioClip clip1;

    private void Start()
    {
        src1.clip = clip1;
        
        InvokeRepeating("HorseSoundEveryFiveSeconds", 0f, 9f);
    }

    private void HorseSoundEveryFiveSeconds()
    {
        src1.Play();
    }


   
}
