using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerDownScript : MonoBehaviour
{
    InputSystem inputScript;
    float originalSpeed;
    float duration = 3f;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Horse")
        {
            Destroy(gameObject);

            // get the script 
            inputScript = other.GetComponent<InputSystem>();

            // save the original speed of the horse then decrease the horse speed 
            originalSpeed = inputScript.speed;
            inputScript.speed *= 0.5f;

            // wait for two seconds then reAssign the speed to the original 
            StartCoroutine(SpeedDown());
        }
    }
    private IEnumerator SpeedDown()
    {
        Debug.LogError("1");
        yield return new WaitForSeconds(duration);

        inputScript.speed = originalSpeed;
        Debug.LogError("2");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
