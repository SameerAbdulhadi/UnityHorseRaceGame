using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class openLevel : MonoBehaviour
{
    public Button[] buttons;

   void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt",3);

        for (int i = 0; i < buttons.Length; i++)
        {
            if(i+3 > levelAt)
                buttons[i].interactable = false;

        }

        

    }


   
}
