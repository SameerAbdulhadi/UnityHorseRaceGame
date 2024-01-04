using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint2 : MonoBehaviour
{
    public GameObject win;
    

    void Start()
    {
        win.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Horse"))
        {
            win.gameObject.SetActive(true);
            Level2RaceManager.instance.race2FinishCount += 1;

            Rigidbody playerRigidbody = other.GetComponent<Rigidbody>();

            if (playerRigidbody != null)
            {
                // Freeze horse
                playerRigidbody.constraints = RigidbodyConstraints.FreezeAll;
            }
        }

    }
    
}
