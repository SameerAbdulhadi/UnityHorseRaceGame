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
        if (other.CompareTag("BrownHorse") || other.CompareTag("BlackHorse"))
        {
            win.gameObject.SetActive(true);
            Level2RaceManager.instance.race2FinishCount += 1;

            if (Level2RaceManager.instance.race2FinishCount == 1)
            {
                if (other.CompareTag("BrownHorse"))
                {

                    scoreToBoard.instance.brownScore += 1700;
                }

                else
                {
                    score2ToBoard.instance.blackScore += 1700;
                }

            }


            else if (Level2RaceManager.instance.race2FinishCount == 2)
            {
                if (other.CompareTag("BrownHorse"))
                {
                    scoreToBoard.instance.brownScore += 1200;
                }

                else
                {
                    score2ToBoard.instance.blackScore += 1200;
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
