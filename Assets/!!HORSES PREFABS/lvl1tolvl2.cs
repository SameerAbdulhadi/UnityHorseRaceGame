/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl1tolvl2 : MonoBehaviour
{
    public static int BrownHorseInstantiated=0;
    public static int BlackHorseInstantiated=0;
    public GameObject blackHorse;
    public GameObject BrownHorse;
    public GameObject playerRespawnPoint;
    public GameObject EnemyRespawnPoint;
    InputSystem inputSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
      
        Rigidbody rb = blackHorse.GetComponent<Rigidbody>();
        rb.Sleep();
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("BlackHorse"))
        {
            Instantiate(blackHorse, playerRespawnPoint.transform.position, playerRespawnPoint.transform.rotation);
            Destroy(other.gameObject);
            BlackHorseInstantiated++;
           

        }
        if (other.CompareTag("BrownHorse"))
        {
            Instantiate(BrownHorse, EnemyRespawnPoint.transform.position, EnemyRespawnPoint.transform.rotation);
            Destroy(other.gameObject);
            BrownHorseInstantiated++;
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
      if(BlackHorseInstantiated == 0)
        {
            
        }
    }
    

    

}
*/
