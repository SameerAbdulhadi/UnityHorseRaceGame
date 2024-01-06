using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGameMusic : MonoBehaviour
{
    public AudioSource mainGameMusic;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        if (SceneManager.GetActiveScene().name == "mainPage" || SceneManager.GetActiveScene().name == "SelectLevel") 
        {
            mainGameMusic.Play();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
