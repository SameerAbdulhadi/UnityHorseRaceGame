using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPoint3 : MonoBehaviour
{
    GameObject child, child1, child2;
    public float delayBeforeLoading = 2f;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BrownHorse") || other.CompareTag("BlackHorse"))
        {
            
            Level3RaceManager.instance.race3FinishCount += 1;


            if (Level3RaceManager.instance.race3FinishCount == 1)
            {
                if (other.CompareTag("BrownHorse"))
                {

                    scoreToBoard.instance.brownScore += 1900;
                    Timer.brownHorseWin = true;
                }

                else
                {
                    score2ToBoard.instance.blackScore += 1900;
                    Timer.blackHorseWin = true;
                }

            }


            else if (Level3RaceManager.instance.race3FinishCount == 2)
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

        if (Level3RaceManager.instance.race3FinishCount >= 2)
        {
            Invoke("LoadEndScene", delayBeforeLoading);
        }


    }


    void LoadEndScene()
    {
        SceneManager.LoadScene("GameEnd");
    }
}
