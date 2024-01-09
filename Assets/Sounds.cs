using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Sounds : MonoBehaviour
{
    public AudioMixer lvl1Sounds;
    public AudioMixer lvl2Sounds;
    public AudioMixer lvl3Sounds;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        lvl1Sounds = GetComponent<AudioMixer>();
       
    }
}
