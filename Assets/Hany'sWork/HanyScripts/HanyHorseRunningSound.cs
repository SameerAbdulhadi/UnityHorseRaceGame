using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanyHorseRunningSound : MonoBehaviour
{
    private Rigidbody rb;
    public AudioSource RunningSrc;
    public AudioClip RunningClip;
    private void Start()
    {
        RunningSrc.clip = RunningClip;
        InvokeRepeating("RunningSound", 0, 0.5f);
    }

    private void Update()
    {       

    }

    private void RunningSound()
    {
       if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)
            || Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.DownArrow))
        {
            RunningSrc.Play();
        }
       else
        {
            RunningSrc.Stop();
        }
    }
}
