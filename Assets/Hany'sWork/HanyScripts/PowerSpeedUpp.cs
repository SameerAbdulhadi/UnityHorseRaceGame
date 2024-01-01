using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class HanyPowerSpeedUp : MonoBehaviour
{
    VolcanoMapInputSystem inputScript;
    

     


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Horse")
        {
            inputScript = other.GetComponent<VolcanoMapInputSystem>();

            StartCoroutine(SpeedUpPower());
        }
    }



    private IEnumerator SpeedUpPower()
    {
        if (inputScript != null)
        {
            float originalSpeed = inputScript.speed;
            inputScript.speed *= 2;

            yield return new WaitForSeconds(2f);
            
                inputScript.speed = originalSpeed;

            
        }
    }
}
