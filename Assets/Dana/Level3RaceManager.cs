using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3RaceManager : MonoBehaviour
{
    public int race3FinishCount = 0;
    public static Level3RaceManager instance;
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
        if (race3FinishCount >= 2)
        {
            Invoke("LoadNextScene", delayBeforeLoading);
        }
    }


    void LoadNextScene()
    {
        SceneManager.LoadScene("GameEnd");
    }
}
