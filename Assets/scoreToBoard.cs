using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreToBoard : MonoBehaviour
{

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

}
