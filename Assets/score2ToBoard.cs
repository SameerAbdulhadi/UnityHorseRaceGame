using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score2ToBoard : MonoBehaviour
{
    public GameObject blackHorse;
    public static score2ToBoard instance;
    public int blackScore;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);

    }


    void Update()
    {
        ScoreManager score2 = blackHorse.GetComponent<ScoreManager>();
        blackScore = score2.score;
    }

}
