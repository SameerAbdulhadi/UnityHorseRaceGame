using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanyDragonSounds : MonoBehaviour
{
    public AudioSource dragonRoar, SkyDragon;
    public AudioClip Roar, SkyRoar;

    private void Start()
    {
        dragonRoar.clip = Roar;
        SkyDragon.clip = SkyRoar;
        InvokeRepeating("TheDragonRoar", 0, 10f);
        InvokeRepeating("TheSkyDragon", 0, 6.5f); 
    }

    private void TheDragonRoar ()
    {
            dragonRoar.Play();
    }

    private void TheSkyDragon ()
    {
        SkyDragon.Play();
    }
}
