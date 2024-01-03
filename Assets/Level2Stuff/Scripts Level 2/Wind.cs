using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public AudioSource windSound;
    
    private void OnTriggerEnter(Collider other) // once collide with the horse
    {
        Rigidbody horseRigidbody = other.GetComponent<Rigidbody>();

        if (horseRigidbody != null)
        {
            ApplyWindEffect(horseRigidbody);
        }
    }

    private void ApplyWindEffect(Rigidbody horseRigidbody)
    {
        
        horseRigidbody.drag*= 0.5f;
        windSound.Play();
    }


    private void OnTriggerExit(Collider other) // once collision is done
    {
        Rigidbody horseRigidbody = other.GetComponent<Rigidbody>();
        
        if (horseRigidbody != null)
        {
            horseRigidbody.drag *= 2f;
        }
    }



}
