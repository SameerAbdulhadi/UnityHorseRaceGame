using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint2 : MonoBehaviour
{
    GameObject child, child1, child2;
    public float delayBeforeLoading = 2f;
    public GameObject blackHorse;
    public GameObject BrownHorse;
    public GameObject playerRespawnPoint;
    public GameObject EnemyRespawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BrownHorse") || other.CompareTag("BlackHorse"))
        {
           
            Level2RaceManager.instance.race2FinishCount += 1;

            if (Level2RaceManager.instance.race2FinishCount == 1)
            {
                if (other.CompareTag("BrownHorse"))
                {

                    scoreToBoard.instance.brownScore += 1700;
                    Timer.brownHorseWin = true;
                }

                else
                {
                    score2ToBoard.instance.blackScore += 1700;
                    Timer.blackHorseWin = true;
                }

            }


            else if (Level2RaceManager.instance.race2FinishCount == 2)
            {
                if (other.CompareTag("BrownHorse"))
                {
                    scoreToBoard.instance.brownScore += 1200;
                    Timer.brownHorseWin = true;
                }

                else
                {
                    score2ToBoard.instance.blackScore += 1200;
                    Timer.blackHorseWin = true;
                }

            }

            child = other.gameObject.transform.GetChild(10).gameObject;
            child1 = child.transform.GetChild(0).gameObject;
            child2 = child1.transform.GetChild(2).gameObject;

            child2.SetActive(true);





            Rigidbody playerRigidbody = other.GetComponent<Rigidbody>();

            if (playerRigidbody != null)
            {
                // Freeze horse
                playerRigidbody.constraints = RigidbodyConstraints.FreezeAll;
            }
        }

        if (Level2RaceManager.instance.race2FinishCount >= 2)
        {
            Invoke("Respawn2", delayBeforeLoading);
        }

    }

    
    public void Respawn2()
    {
        Instantiate(blackHorse, playerRespawnPoint.transform.position, playerRespawnPoint.transform.rotation);
        Instantiate(BrownHorse, EnemyRespawnPoint.transform.position, EnemyRespawnPoint.transform.rotation);
    }


}
