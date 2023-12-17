using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorAreaOne : MonoBehaviour
{
    public GameObject box;
    public List<GameObject> shootingPoints;
    private void OnTriggerEnter(Collider other)
    {
        foreach (GameObject index in shootingPoints)
            Instantiate(box, index.transform.position, index.transform.rotation);
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
