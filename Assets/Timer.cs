using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    GameObject child, child1, child2; //black horse
    GameObject child3, child4, child5; //brown horse
    GameObject blackHorse, brownHorse;
    public static bool blackHorseWin = false, brownHorseWin = false;
    EndPoint2 endPoint2;
    EndPoint1 endPoint1;
    public float delayBeforeLoading = 2f;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    private void Awake()
    {
        blackHorse = GameObject.FindGameObjectWithTag("BlackHorse");
        brownHorse = GameObject.FindGameObjectWithTag("BrownHorse");
        child = blackHorse.transform.GetChild(10).gameObject;
        child1 = child.transform.GetChild(0).gameObject;
        child2 = child1.transform.GetChild(1).gameObject;
        child2.SetActive(false);
        child3 = brownHorse.transform.GetChild(10).gameObject;
        child4 = child.transform.GetChild(0).gameObject;
        child5 = child1.transform.GetChild(1).gameObject;
        child5.SetActive(false);
    }
    private void Start()
    {
        if (lvl1tolvl2.BlackHorseInstantiated == 1) //lvl 1
            remainingTime = 150;
        if (lvl1tolvl2.BlackHorseInstantiated == 2)//lvl2
            remainingTime = 200;

        else if (lvl1tolvl2.BlackHorseInstantiated == 3)
            remainingTime = 165;// lvl3


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
            
            if (brownHorseWin)
                child2.SetActive(true);
            if (blackHorseWin)
                child5.SetActive(true);

            if (lvl1tolvl2.BlackHorseInstantiated == 2)
            {
                Level2RaceManager.instance.race2FinishCount += 1;
            }
            else if (lvl1tolvl2.BlackHorseInstantiated == 1)
                Level1RaceManager.instance.race1FinishCount += 1;
            else if (lvl1tolvl2.BlackHorseInstantiated == 3)
                Level3RaceManager.instance.race3FinishCount += 1;
        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (lvl1tolvl2.BlackHorseInstantiated == 2)
            if (Level2RaceManager.instance.race2FinishCount >= 2)
                endPoint2.Respawn2();

            else if (lvl1tolvl2.BlackHorseInstantiated == 1)
                if (Level1RaceManager.instance.race1FinishCount >= 2)
                    endPoint1.Respawn();

                else if (lvl1tolvl2.BlackHorseInstantiated == 3)
                    if (Level3RaceManager.instance.race3FinishCount >=2)
                        Invoke("LoadEndScene", delayBeforeLoading);
    }
    void LoadEndScene()
    {
        SceneManager.LoadScene("GameEnd");
    }
    /*public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }*/
}
