using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreToBoard : MonoBehaviour
{
    public GameObject brownHorse;
    public static scoreToBoard instance;
    public int brownScore;

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
        ScoreManager score1 = brownHorse.GetComponent<ScoreManager>();
        brownScore = score1.score;
    }
}
