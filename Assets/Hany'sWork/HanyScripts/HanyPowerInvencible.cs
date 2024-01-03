using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanyPowerInvencible : MonoBehaviour
{
    float duration = 3f;
    AudioSource src;
    bool doneCoroutine = false;
    GameObject[] obstacles; 
    private void Start()
    {
        src = GetComponent<AudioSource>();
        obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Horse")
        {
            src.Play();


            other.enabled = false;
            // wait for two seconds then reAssign the speed to the original 
            StartCoroutine(Invencible(other));
        
        }
    }

    private IEnumerator Invencible(Collider otherCollider)
    {

        yield return new WaitForSeconds(duration);

        otherCollider.enabled = true;
    }

}
