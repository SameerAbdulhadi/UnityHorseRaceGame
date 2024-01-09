using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1RaceManager : MonoBehaviour
{
    public int race1FinishCount = 0;
    public static Level1RaceManager instance;
   

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }


}
