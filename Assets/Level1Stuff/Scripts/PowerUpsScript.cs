using System.Collections;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpsScript : MonoBehaviour
{
    InputSystem inputScript;
    float originalSpeed;
    float duration = 1f;

    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Horse")
        {
            Destroy(gameObject);

            // get the script 
            inputScript = other.GetComponent<InputSystem>();

            // save the original speed of the horse then double the horse speed 
            originalSpeed = inputScript.speed;
            inputScript.speed *= 5.5f;

            // wait for two seconds then reAssign the speed to the original 
            StartCoroutine(SpeedUp());
        }
    }
    private IEnumerator SpeedUp()
    {
        Debug.Log("Speed increased");
        yield return new WaitForSeconds(duration);
      
        inputScript.speed = originalSpeed;
        Debug.Log("Speed reset");

    }
}
