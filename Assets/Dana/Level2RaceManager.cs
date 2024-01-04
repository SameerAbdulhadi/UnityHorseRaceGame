using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2RaceManager : MonoBehaviour
{
    public int race2FinishCount = 0;
    public static Level2RaceManager instance;
    public float delayBeforeLoading = 2f;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }



    void Update()
    {
        if (race2FinishCount >= 2)
        {
            Invoke("LoadNextScene", delayBeforeLoading);
        }
    }


    void LoadNextScene()
    {
        SceneManager.LoadScene("Level_4_VolcanoMap");
    }
}
