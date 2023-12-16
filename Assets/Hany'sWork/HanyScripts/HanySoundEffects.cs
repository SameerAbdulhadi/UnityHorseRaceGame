using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanySoundEffects : MonoBehaviour
{
    public AudioSource Src;
    public AudioClip HorseHitThefence;

    private void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Horse")
        {
            Src.clip = HorseHitThefence;
            Src.Play();
        }
    }
}
