using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPoint1 : MonoBehaviour
{
    GameObject child, child1, child2;
    public float delayBeforeLoading = 2;
    public GameObject blackHorse;
    public GameObject BrownHorse;
    public GameObject playerRespawnPoint;
    public GameObject EnemyRespawnPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BrownHorse") || other.CompareTag("BlackHorse"))
        {

            Level1RaceManager.instance.race1FinishCount += 1;

            if (Level1RaceManager.instance.race1FinishCount == 1)
            {
                if (other.CompareTag("BrownHorse"))
                {
                    scoreToBoard.instance.brownScore += 1500;
                    Timer.brownHorseWin = true;
                }

                else
                {
                    score2ToBoard.instance.blackScore += 1500;
                    Timer.blackHorseWin = true;
                }

            }


            else if (Level1RaceManager.instance.race1FinishCount == 2)
            {
                if (other.CompareTag("BrownHorse"))
                {
                    scoreToBoard.instance.brownScore += 1000;
                    Timer.brownHorseWin = true;
                }

                else
                {
                    score2ToBoard.instance.blackScore += 1000;
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
            if (Level1RaceManager.instance.race1FinishCount >= 2)
                Invoke("Respawn", delayBeforeLoading);
    }
    
    public void Respawn()
    {
        Instantiate(blackHorse, playerRespawnPoint.transform.position, playerRespawnPoint.transform.rotation);
        Instantiate(BrownHorse, EnemyRespawnPoint.transform.position, EnemyRespawnPoint.transform.rotation);
    }
}
