using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HorseProperties : MonoBehaviour
{
    private GameObject horse;
    Vector3 L1, L2, L3;
    // Start is called before the first frame update
    void Awake()
    {
        horse = GameObject.FindWithTag("Horse");
        L1.x = 4; L1.y = 4; L1.z = 4;
        L2.x = 5; L2.y = 5; L2.z = 5;
        L3.x = 91; L3.y = 91; L3.z = 91;
        string activeScene = SceneManager.GetActiveScene().name;
        if (activeScene == "Level_2.0")
        {
            horse.transform.localScale = L2;
        }
        else if (activeScene == "Level_1") {
            horse.transform.localScale = L1;
        }

        else if (activeScene == "Level_4_Volcano Map") {
            horse.transform.localScale = L3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
