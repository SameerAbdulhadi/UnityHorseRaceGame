using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint3 : MonoBehaviour
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
            Level3RaceManager.instance.race3FinishCount += 1;


            if (Level3RaceManager.instance.race3FinishCount == 1)
            {
                if (other.CompareTag("BrownHorse"))
                {

                    scoreToBoard.instance.brownScore += 1900;
                }

                else
                {
                    score2ToBoard.instance.blackScore += 1900;
                }

            }


            else if(Level3RaceManager.instance.race3FinishCount == 2)
            {
                if (other.CompareTag("BrownHorse"))
                {

                    scoreToBoard.instance.brownScore += 1400;
                }

                else
                {
                    score2ToBoard.instance.blackScore += 1400;
                }

            }



            Rigidbody playerRigidbody = other.GetComponent<Rigidbody>();

            if (playerRigidbody != null)
            {
                // Freeze horse
                playerRigidbody.constraints = RigidbodyConstraints.FreezeAll;
            }
        }
    }
}
