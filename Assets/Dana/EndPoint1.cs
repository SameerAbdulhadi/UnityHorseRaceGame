using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPoint1 : MonoBehaviour
{
    public GameObject win;

    void Start()
    {
        win.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Horse"))
        {
            win.gameObject.SetActive(true);
            Level1RaceManager.instance.race1FinishCount += 1;

            Rigidbody playerRigidbody = other.GetComponent<Rigidbody>();

            if (playerRigidbody != null)
            {
                // Freeze horse
                //playerRigidbody.constraints = RigidbodyConstraints.FreezeAll;
            }
        }
    }
}
