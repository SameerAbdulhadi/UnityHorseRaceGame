using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseRunningShound : MonoBehaviour
{
    public AudioSource Running;
    public AudioSource RunningFast;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A)||
            Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.D)||
            Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.DownArrow)
            ||Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.RightArrow))
        {
            Running.enabled = true;
            
        }
        else
        {
            Running.enabled=false;
        }
    }
}
