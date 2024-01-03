using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanyPowerFreeze : MonoBehaviour
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

            // save the original speed of the horse freeze the horse speed 
            originalSpeed = inputScript.speed;
            inputScript.speed = 0;

            // wait for two seconds then reAssign the speed to the original 
            StartCoroutine(FreezePowerDown());
        }
    }
    private IEnumerator FreezePowerDown ()
    {
        yield return new WaitForSeconds(duration);

        inputScript.speed = originalSpeed;
    }
}
