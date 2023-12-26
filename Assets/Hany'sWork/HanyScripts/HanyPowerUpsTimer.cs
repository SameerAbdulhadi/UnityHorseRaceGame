using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HanyPowerUpsTimer : MonoBehaviour
{
    private float timer = 0; 
    public List<GameObject> positions = new List<GameObject>();
    public GameObject[] GoodPowerUps = new GameObject[2]; 
    public GameObject[] BadPowerUps = new GameObject[2];


    private void Start()
    {
        Invoke("LevelTwo", 36);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;       
    }

    private void LevelTwo()
    {

        for (int i = 0; i < 6; i++)
        {
            //generate 4 random numbers , two of them for the positions childs , and two of them are for choosing the power ups. 
            int goodPositionsRandom = Random.Range(0, 3);
            int goodPowerRandom = Random.Range(0, 2);

            // instantiate the good power ups. 
            GameObject instantiated = Instantiate(GoodPowerUps[goodPowerRandom], positions[i].transform.GetChild(goodPositionsRandom).position,
                positions[i].transform.GetChild(goodPositionsRandom).rotation);
            instantiated.transform.Translate(0,60,0);
        }



        for (int i = 0; i < 6; i++)
        {
            //generate 4 random numbers , two of them for the positions childs , and two of them are for choosing the power ups. 
            int badPositionsRandom = Random.Range(0, 3);
            int badPowerRandom = Random.Range(0, 2);

            //instantiate the bad power ups. 
            GameObject instantiated = Instantiate(BadPowerUps[badPowerRandom], positions[i].transform.GetChild(badPositionsRandom).position,
                    positions[i].transform.GetChild(badPositionsRandom).rotation);
            instantiated.transform.Translate(0, 60, 0);
        }

    }

    private void LevelThree()
    {
        if (timer >= 60)
        {
            print("Level three");
        }
    }
}
