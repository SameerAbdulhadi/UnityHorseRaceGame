using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorAreaTwo : MonoBehaviour
{
    public List<GameObject> pillars;
    private void OnTriggerEnter(Collider other)
    {
        foreach (GameObject pillar in pillars)
        {
            Vector3 pillarY = pillar.transform.position;
            pillar.transform.Rotate(pillarY.x, pillarY.y, 90);
        }
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
