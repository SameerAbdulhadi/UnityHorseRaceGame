using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HanyHitObstacles : MonoBehaviour
{
    public GameObject checkPoints;
    HanyPowerInvencible invencibleScript;
    VolcanoMapInputSystem inputScript;
    HanyLevelsManager timerScript;
    private GameObject PlayerImagesRef; 

    private void Start()
    {
        timerScript = FindObjectOfType<HanyLevelsManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
            inputScript = other.GetComponent<VolcanoMapInputSystem>();
              PlayerImagesRef = inputScript.playerLivesImages;
        if (other.tag == "Horse")
        {
            inputScript.horseLives--;
            LifeImages(inputScript);
            if (inputScript.horseLives > 0)
            {
                GoTolastCheckPoint(other.gameObject);
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        
    }

    private void GoTolastCheckPoint(GameObject horse)
    {
        // go to checkpoint 1 
        if(horse.transform.position.x >= 6741 && horse.transform.position.x <= 7700 
            && horse.transform.position.z >= 2382 && horse.transform.position.z <= 4000)
        {
            horse.transform.position =checkPoints.transform.GetChild(0).transform.position;
         }

        // go to check point 2 
        if (horse.transform.position.x >= 5700 && horse.transform.position.x <= 7739
            && horse.transform.position.z >= 6400 && horse.transform.position.z <= 7000)
        {
            horse.transform.position = checkPoints.transform.GetChild(1).transform.position;
 
        }

        //go to check point 3 
        if (horse.transform.position.x >= 6802 && horse.transform.position.x <= 7771
            && horse.transform.position.z >= 9864 && horse.transform.position.z <= 10598)
        {
            horse.transform.position = checkPoints.transform.GetChild(2).transform.position;
 
        }

        //go to checkpoint 4 
        if (horse.transform.position.x >= 4567 && horse.transform.position.x <= 5589
            && horse.transform.position.z >= 11977 && horse.transform.position.z <= 13289)
        {
            horse.transform.position = checkPoints.transform.GetChild(3).transform.position;
            horse.transform.rotation = checkPoints.transform.GetChild(3).rotation;
 
        }

        //go to checkpoint 5
        if (horse.transform.position.x >= 2348 && horse.transform.position.x <= 3704
            && horse.transform.position.z >= 10661 && horse.transform.position.z <= 11770)
        {
            horse.transform.position = checkPoints.transform.GetChild(4).transform.position;
            horse.transform.rotation = checkPoints.transform.GetChild(4).rotation;
 
        }

        //go to checkpoint 6
        if (horse.transform.position.x >= 3052 && horse.transform.position.x <= 3660
            && horse.transform.position.z >= 9551 && horse.transform.position.z <= 10650)
        {
            horse.transform.position = checkPoints.transform.GetChild(5).transform.position;
            horse.transform.rotation = checkPoints.transform.GetChild(5).rotation;
 
        }

        //go to checkpoint 7
        if (horse.transform.position.x >= 2225 && horse.transform.position.x <= 4378
            && horse.transform.position.z >= 5778 && horse.transform.position.z <= 8672)
        {
            horse.transform.position = checkPoints.transform.GetChild(6).transform.position;
            horse.transform.rotation = checkPoints.transform.GetChild(6).rotation;
         }

        //go to checkpoint 8
        if (horse.transform.position.x >= 2400 && horse.transform.position.x <= 3349
            && horse.transform.position.z >= 3756 && horse.transform.position.z <= 5053)
        {
            horse.transform.position = checkPoints.transform.GetChild(7).transform.position;
            horse.transform.rotation = checkPoints.transform.GetChild(7).rotation;
 
        }

        //go to checkpoint 9
        if (horse.transform.position.x >= 2768 && horse.transform.position.x <= 3500
            && horse.transform.position.z >= 2731 && horse.transform.position.z <= 3537)
        {
            horse.transform.position = checkPoints.transform.GetChild(8).transform.position;
            horse.transform.rotation = checkPoints.transform.GetChild(8).rotation;
 
        }

        //go to checkpoint 10
        if (horse.transform.position.x >= 3300 && horse.transform.position.x <= 6200
            && horse.transform.position.z >= 1457 && horse.transform.position.z <= 2656)
        {
            horse.transform.position = checkPoints.transform.GetChild(9).transform.position;
            horse.transform.rotation = checkPoints.transform.GetChild(9).rotation;
 
        }

    }

    private void LifeImages(VolcanoMapInputSystem gameObject)
    {

        if (gameObject.horseLives == 2)
        {
            gameObject.playerLivesImages.transform.GetChild(2).gameObject.SetActive(false);
        }

        if (gameObject.horseLives == 1)
        {
            gameObject.playerLivesImages.transform.GetChild(1).gameObject.SetActive(false);
        }

        if (gameObject.horseLives == 0)
        {
            gameObject.playerLivesImages.transform.GetChild(0).gameObject.SetActive(false);
        }  
    }
    }
