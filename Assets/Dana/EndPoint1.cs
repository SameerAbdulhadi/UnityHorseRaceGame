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
        if (other.CompareTag("BrownHorse") || other.CompareTag("BlackHorse"))
        {




            win.gameObject.SetActive(true);
            Level1RaceManager.instance.race1FinishCount += 1;

            if (Level1RaceManager.instance.race1FinishCount == 1)
            {
                if (other.CompareTag("BrownHorse"))
                {
                    scoreToBoard.instance.brownScore += 1500;
                }

                else
                {
                    score2ToBoard.instance.blackScore += 1500;
                }

            }


            else if (Level1RaceManager.instance.race1FinishCount == 2)
            {
                if (other.CompareTag("BrownHorse"))
                {
                    scoreToBoard.instance.brownScore += 1000;
                }

                else
                {
                    score2ToBoard.instance.blackScore += 1000;
                }

            }


            Rigidbody playerRigidbody = other.GetComponent<Rigidbody>();

            if (playerRigidbody != null)
            {
                // Freeze horse
                //playerRigidbody.constraints = RigidbodyConstraints.FreezeAll;
            }
        }
    }
}
