using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchBox : MonoBehaviour
{
    public GameObject Sphere;
    private void OnTriggerEnter(Collider other)
    {
            Life life = other.GetComponent<Life>();
            if (life != null)
                life.amount -= 5;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
