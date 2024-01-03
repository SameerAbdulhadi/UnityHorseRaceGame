using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TombSensor : MonoBehaviour
{
    public AudioSource thunderSound;
    public AudioSource doorSound;
    private int delay;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        delay = Random.Range(3, 10);
        thunderSound.PlayDelayed(delay);
        doorSound.PlayDelayed(delay);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
