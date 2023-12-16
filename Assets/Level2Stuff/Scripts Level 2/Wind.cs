using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    
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
