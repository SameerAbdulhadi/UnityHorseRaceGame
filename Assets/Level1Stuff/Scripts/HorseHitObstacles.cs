using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseHitObstacles : MonoBehaviour
{
    public AudioSource horseGotHit;
    public AudioSource horseHit;

    //private void Update()
    //{
         void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Fence"))
            {

            PlaySound();
                //horseHit.enabled = true;
                //horseGotHit.enabled = true;
            }
            else
            {
                //horseHit.enabled = false;
                //horseGotHit.enabled = false;
            }
        }
        void PlaySound()
        {
        horseHit.Play();
        horseGotHit.Play();
        }
    }
//}
