using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private float delay = 7;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, delay);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
