using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanyPowerUpsTrigger : MonoBehaviour
{
    float turnSpeed = 140f; 

    // Update is called once per frame
    void Update()
    {
        PowerUpsRotation();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Horse")
        {
            Destroy(this.gameObject);
        }
    }


    private void PowerUpsRotation()
    {
        transform.Rotate(0,turnSpeed*Time.deltaTime,0);
    }
}
