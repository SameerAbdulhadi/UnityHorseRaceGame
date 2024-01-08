using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreBoard : MonoBehaviour
{
    public int black;
    public int brown;

    public TMP_Text name1;
    public TMP_Text name2;
    public TMP_Text score1;
    public TMP_Text score2;

    public GameObject Board;


    void Start()
    {
        Board.SetActive(false);
        float delayInSeconds = 8f;

        
        Invoke("ShowScoreboard", delayInSeconds);
    }

    void ShowScoreboard()
    {
        Board.SetActive(true);
        
        SetTextPositions();
    }

    void Update()
    {
         if(brown > black)
        {
            name1.text = "BROWN";
            score1.text = brown.ToString();
            name2.text = "BLACK";
            score2.text = black.ToString();
        }

         else
        {

            name2.text = "BROWN";
            score2.text = brown.ToString();
            name1.text = "BLACK";
            score1.text = black.ToString();
        }
        SetTextPositions();
    }

    void SetTextPositions()
    {

        RectTransform name1Transform = name1.rectTransform;
        RectTransform score1Transform = score1.rectTransform;

        name1Transform.anchoredPosition = new Vector2(300.7f, 30f); // Adjust as needed
        score1Transform.anchoredPosition = new Vector2(162.4f, 30f);  // Adjust as needed

        RectTransform name2Transform = name2.rectTransform;
        RectTransform score2Transform = score2.rectTransform;

       
        name2Transform.anchoredPosition = new Vector2(300.7f, -42f); // Adjust as needed
        score2Transform.anchoredPosition = new Vector2(162.4001f, -42f);  // Adjust as needed 
    }
}

