using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxEffects : MonoBehaviour
{
    private int delay = 2;
    public ParticleSystem brakeEffect;
    public AudioSource brakeSound;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnDestroy()
    {
        PlayEffects();
    }
    private void PlayEffects()
    {
        brakeEffect.Play();
        brakeSound.Play();
    }
}
