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
    private float timer = 0; 
    public List<GameObject> positions = new List<GameObject>();
    public GameObject[] GoodPowerUps = new GameObject[2]; 
    public GameObject[] BadPowerUps = new GameObject[2];
    public float lapsCounter = 0; 
    private List<GameObject> AllPowerUps = new List<GameObject>();
    private bool levelTwoWasCalled = false ;
    private bool levelThreeWasCalled = false;
    public Canvas canvas;
    public Canvas gameover;
    public Image circle;

    private void Awake()
    {

        if (canvas != null)
        {
            canvas.enabled = false;
        }

        if (gameover != null)
        {
            gameover.enabled = false;
        }

        if(circle!=null)
        {
            circle.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        // invoke level two 

        if (lapsCounter == 2 && levelTwoWasCalled == false   )
        {
            LevelTwo();
            levelTwoWasCalled = true;
        }

        //invoke level three and clear level two 

        if (lapsCounter == 3 && levelThreeWasCalled == false )
        {
             
            ClearLevelTwo();
            InvokeRepeating( "LevelThree", 1 ,10);

            levelThreeWasCalled = true;
            
        }

        //the end action 

        if(lapsCounter==4 && levelThreeWasCalled==true)
        {
            ClearLevelTwo();
            GameOver();
        }
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
            AllPowerUps.Add(instantiated);

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
            AllPowerUps.Add(instantiated2);

            GameObject instantiated3 = Instantiate(BadPowerUps[badPowerRandom2], positions[i].transform.GetChild(badPositionsRandom2).position,
                   positions[i].transform.GetChild(badPositionsRandom2).rotation);
            instantiated3.transform.Translate(0, 60, 0);
            AllPowerUps.Add(instantiated3);

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

    private void LevelThree()
    {
        circle.enabled = true;
        LevelTwo();
        StartCoroutine(CircleIncrease());
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Horse")
        {
            if(timer>0 && timer <=10)
            {
                lapsCounter = 1;
            }

            if(timer>=23)
            {
                lapsCounter = 2;
            }

            if (timer>=54)
            {
                lapsCounter = 3;
            }

            if(timer >= 80)
            {
                lapsCounter = 4;
            }
        }
    }

    private IEnumerator ImageController()
    {
        canvas.enabled = true;
        yield return new WaitForSeconds(4);
        canvas.enabled = false;
    }

    public IEnumerator CircleIncrease()
    {

        while (circle.transform.localScale.x <= 7)
        {
            Vector3 current = circle.transform.localScale;
            float scale = 0.3f;
            Vector3 newScale = new Vector3(current.x + scale, current.y + scale, current.z);
            circle.transform.localScale = newScale;
            yield return new WaitForSeconds(.1f);

        }

        yield return new WaitForSeconds(1);

        StartCoroutine(CircleDecrease());

    }

    public IEnumerator CircleDecrease()
    {

        while (circle.transform.localScale.x > 1)
        {
            Vector3 current = circle.transform.localScale;
            float scale = 0.3f;
            Vector3 newScale = new Vector3(current.x - scale, current.y - scale, current.z);
            circle.transform.localScale = newScale;
            if (circle.transform.localScale.x > 0 && circle.transform.localScale.x < 1)
            {
                circle.transform.localScale = Vector3.zero;
            }
            yield return new WaitForSeconds(.1f);
        }
    }


    public void GameOver ()
    {
        canvas.enabled = false;
        circle.enabled = false;
        Time.timeScale = 0;
        if(gameover!= null)
        {
            Debug.Log("!=null"); 
            gameover.enabled = true;
        }
    }


    
}