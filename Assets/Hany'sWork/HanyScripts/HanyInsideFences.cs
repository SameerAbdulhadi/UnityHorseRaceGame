using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanyInsideFences : MonoBehaviour
{

    // this script's purpose is if the horse collides with the inside fences the script will force the horse to go to the right. 
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Horse")
        {
            other.transform.Translate(new Vector3(5, 0, 0),Space.World);
            
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Horse")
        {
            other.transform.Translate(new Vector3(15, 0, 0),Space.World);

        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
