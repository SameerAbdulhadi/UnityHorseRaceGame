using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score2ToBoard : MonoBehaviour
{
   
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


}
