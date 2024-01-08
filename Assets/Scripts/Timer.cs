using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public GameObject lose;


    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    private void Start()
    {

        lose.gameObject.SetActive(false);

        string activeScene = SceneManager.GetActiveScene().name;
        if (activeScene == "Level_2.0")
            remainingTime = 200;
        else if (activeScene == "Level_1")
            remainingTime = 135;
        else if (activeScene == "Level_4_Volcano Map")
            remainingTime = 165;

    }
    // Update is called once per frame
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            timerText.color = Color.red;



            lose.gameObject.SetActive(true);
            string activeScene = SceneManager.GetActiveScene().name;

            if (activeScene == "Level_2.0")
                Level2RaceManager.instance.race2FinishCount += 1;

            else if (activeScene == "Level_1")
                Level1RaceManager.instance.race1FinishCount += 1;


            else if (activeScene == "Level_4_Volcano Map")
                Level3RaceManager.instance.race3FinishCount += 1;



        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    /*public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }*/
}
