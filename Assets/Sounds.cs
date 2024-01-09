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
        if (lvl1tolvl2.BlackHorseInstantiated == 0 && lvl1tolvl2.BrownHorseInstantiated == 0)
        {
            lvl1Sounds.SetFloat("VolumeParameter", 0);
            lvl2Sounds.SetFloat("VolumeParameter", 0);
            lvl3Sounds.SetFloat("VolumeParameter", 0);
        }
        if (lvl1tolvl2.BlackHorseInstantiated == 1 && lvl1tolvl2.BrownHorseInstantiated == 1)
        {
            lvl1Sounds.SetFloat("VolumeParameter", 0);
            lvl2Sounds.SetFloat("VolumeParameter", 0);
            lvl3Sounds.SetFloat("VolumeParameter", 0);
        }
        if (lvl1tolvl2.BlackHorseInstantiated == 2 && lvl1tolvl2.BrownHorseInstantiated == 2)
        {
            lvl1Sounds.SetFloat("VolumeParameter", 0);
            lvl2Sounds.SetFloat("VolumeParameter", 0);
            lvl3Sounds.SetFloat("VolumeParameter", 0);
        }
    }
}
