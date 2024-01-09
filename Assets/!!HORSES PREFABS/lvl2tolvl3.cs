using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl2tolvl3 : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("BlackHorse"))
        {
            
            lvl1tolvl2.BlackHorseInstantiated++;

        }
        if (other.CompareTag("BrownHorse"))
        {
            lvl1tolvl2.BrownHorseInstantiated++;
        }

    }
}

