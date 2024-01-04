using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanyPowerSpeedDown : MonoBehaviour
{
    VolcanoMapInputSystem inputScript;
    float originalSpeed;
    float duration = 3f;
    AudioSource src;

    private void Start()
    {
        src = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Horse")
        {
            src.Play();

            // get the script 
            inputScript = other.GetComponent<VolcanoMapInputSystem>();

            // save the original speed of the horse then decrease the horse speed 
            originalSpeed = inputScript.speed;
            inputScript.speed *= 0.5f;

            // wait for two seconds then reAssign the speed to the original 
            StartCoroutine(SpeedDown());
        }
    }

    private IEnumerator SpeedDown()
    {
        yield return new WaitForSeconds(duration);

        inputScript.speed = originalSpeed; 
        
    }
}
