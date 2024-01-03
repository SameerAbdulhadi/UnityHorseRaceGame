using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private int delay = 3;
    public ParticleSystem boxBrake;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, delay);
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnDestroy()
    {
        boxBrake.Play();
        print("destroyed");
    }
}
