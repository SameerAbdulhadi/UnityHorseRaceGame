using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class HanyLevelsManager : MonoBehaviour
{
    int reservedLocation; 
    public List<GameObject> positions = new List<GameObject>();
    public GameObject[] GoodPowerUps = new GameObject[2]; 
    public GameObject[] BadPowerUps = new GameObject[2];
    private List<GameObject> AllPowerUps = new List<GameObject>();

    private void Start()
    {
        LevelTwo();
    }

    private void LevelTwo()
    {

        for (int i = 0; i < 6; i++)
        {
            //generate 4 random numbers , two of them for the positions childs , and two of them are for choosing the power ups. 
            int goodPositionsRandom = Random.Range(0, 3);
            int goodPowerRandom = Random.Range(0, 2);
             reservedLocation = goodPositionsRandom; 
            
            // instantiate the good power ups. 
            GameObject instantiated = Instantiate(GoodPowerUps[goodPowerRandom], positions[i].transform.GetChild(goodPositionsRandom).position,
                positions[i].transform.GetChild(goodPositionsRandom).rotation);
            instantiated.transform.Translate(0,60,0);
          //  AllPowerUps.Add(instantiated);

            // instantiate the bad powers: 
            int badPositionsRandom;
            int badPositionsRandom2;
            //generate 4 random numbers , two of them for the positions childs , and two of them are for choosing the power ups. 
            do
            {
                badPositionsRandom = Random.Range(0, 3);
            } while (badPositionsRandom == reservedLocation);

            do
            {
                badPositionsRandom2 = Random.Range(0, 3);
            } while (badPositionsRandom2 == reservedLocation || badPositionsRandom2 == badPositionsRandom);

            int badPowerRandom = Random.Range(0, 2);
            int badPowerRandom2 = Random.Range(0, 2);

            //instantiate the bad power ups. 
            GameObject instantiated2 = Instantiate(BadPowerUps[badPowerRandom], positions[i].transform.GetChild(badPositionsRandom).position,
                    positions[i].transform.GetChild(badPositionsRandom).rotation);
            instantiated2.transform.Translate(0, 60, 0);
         //   AllPowerUps.Add(instantiated2);

            GameObject instantiated3 = Instantiate(BadPowerUps[badPowerRandom2], positions[i].transform.GetChild(badPositionsRandom2).position,
                   positions[i].transform.GetChild(badPositionsRandom2).rotation);
            instantiated3.transform.Translate(0, 60, 0);
           // AllPowerUps.Add(instantiated3);

        }

    }

    private void ClearLevelTwo ()
    {
        // destroy all the power ups in the scene. 

        foreach (GameObject g in AllPowerUps)
        {
            Destroy(g);
        }
    }
}
