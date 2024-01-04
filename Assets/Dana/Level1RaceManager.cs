using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1RaceManager : MonoBehaviour
{
    public int race1FinishCount = 0;
    public static Level1RaceManager instance;
    public float delayBeforeLoading = 2f;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }


    
    void Update()
    {
        if(race1FinishCount >= 2)
        {
            Invoke("LoadNextScene", delayBeforeLoading);
        }
    }


    void LoadNextScene()
    {
        SceneManager.LoadScene("Level_2.0");
    }
}
