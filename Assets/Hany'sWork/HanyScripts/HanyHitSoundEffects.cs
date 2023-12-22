using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanySoundEffects : MonoBehaviour
{
    public AudioSource Src1;
    public AudioSource Src2;

    public AudioClip HorseHitThefence;
    public AudioClip HitSound;

    private void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Horse")
        {
            Src1.clip = HorseHitThefence;
            Src1.Play();

            Src2.clip = HitSound; 
            Src2.Play();
        }
    }
}
