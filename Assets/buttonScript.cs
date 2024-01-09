using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonScript : MonoBehaviour
{
     float delayInSeconds = 10f;
    public GameObject button;
  
    void Start()
    {
        button.SetActive(false);
        Invoke("SetButton", delayInSeconds);
    }


    public void SetButton()
    {
        button.SetActive(true);
    }
    
    void GOTOMainPage()
    {
        SceneManager.LoadScene("MainPage");
    }
}
