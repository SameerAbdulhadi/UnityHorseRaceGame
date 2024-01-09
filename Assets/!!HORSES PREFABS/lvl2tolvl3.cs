using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl2tolvl3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public GameObject blackHorse;
    public GameObject BrownHorse;
    public GameObject playerRespawnPoint;
    public GameObject EnemyRespawnPoint;
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("BlackHorse"))
        {
            Instantiate(blackHorse, playerRespawnPoint.transform.position, playerRespawnPoint.transform.rotation);
            Destroy(other.gameObject);
            lvl1tolvl2.BlackHorseInstantiated++;

        }
        if (other.CompareTag("BrownHorse"))
        {
            Instantiate(BrownHorse, EnemyRespawnPoint.transform.position, EnemyRespawnPoint.transform.rotation);
            Destroy(other.gameObject);
            lvl1tolvl2.BrownHorseInstantiated++;
        }

    }
}
