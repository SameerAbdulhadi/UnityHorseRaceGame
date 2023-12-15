using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PausedPanel : MonoBehaviour
{
    public  GameObject pausedPanel;

    public bool isPaused;

    
    public void pauseGame()
    {
        pausedPanel.SetActive(true);
        Time.timeScale = 0;
      

    }

    public void resumeGame()
    {
        pausedPanel.SetActive(false);
        Time.timeScale = 1;

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }



    public void Home()
    {
        SceneManager.LoadScene(1);
    }
}

