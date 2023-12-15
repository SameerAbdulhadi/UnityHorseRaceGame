using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanyOutsideFence : MonoBehaviour
{

    // the outside fences script purpose is for the outside fences if the horse collides with them
    //this script well force the horse to go to the left.

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Horse")
        {
            other.transform.Translate(new Vector3(-5, 0, 0), Space.World);

        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Horse")
        {
            other.transform.Translate(new Vector3(-15, 0, 0), Space.World);

            //other.transform.Translate(5, 0, 0);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
