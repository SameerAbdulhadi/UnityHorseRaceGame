using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanySmokeSound : MonoBehaviour
{
    public AudioSource smokeSrc; 
    public AudioClip SmokeHit ;

    private void Start()
    {
        smokeSrc.clip = SmokeHit;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Horse")
        {
            smokeSrc.clip = SmokeHit;
            smokeSrc.Play();
        }
    }
}
