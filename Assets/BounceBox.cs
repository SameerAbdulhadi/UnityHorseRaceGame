using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceBox : MonoBehaviour
{
    private int delay = 2;
    public ParticleSystem brakeEffect;
    public AudioSource brakeSound;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, delay);
        brakeEffect.Play();
        brakeSound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
