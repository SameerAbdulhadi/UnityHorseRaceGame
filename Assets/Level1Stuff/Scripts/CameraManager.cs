using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Horse1; // Reference to the cameras in the racing scene
    public GameObject Horse2;   // Reference to the cameras in the menu scene

    void Awake()
    {
        // Check if the active scene is the menu scene
        if (SceneManager.GetActiveScene().name == "HorseSelection")
        {
            DisableHorse2();
            DisableHorse1();
        }
        else
        {
            EnableHorse1();
            EnableHorse2();
        }
    }
    void DisableHorse2()
    {
        Horse2.SetActive(false);
    }
    void DisableHorse1()
    {
        Horse1.SetActive(false);
    }
    void EnableHorse2()
    {
        Horse2.SetActive(true);
    }
    void EnableHorse1()
    {
        Horse1.SetActive(true);
    }

}

