using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HanyPowerSpeedUpp : MonoBehaviour
{
    VolcanoMapInputSystem inputScript;
    float originalSpeed;
    float duration = 2f;

    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Horse")
        {
            inputScript = other.GetComponent<VolcanoMapInputSystem>();
            originalSpeed = inputScript.speed;
            inputScript.speed *= 2;

            StartCoroutine(SpeedUp());
        }
    }

    private IEnumerator SpeedUp()
    {        
        yield return new WaitForSecondsRealtime(duration);

        inputScript.speed = originalSpeed;
        print("the coroutine is done"); 
    }

}
