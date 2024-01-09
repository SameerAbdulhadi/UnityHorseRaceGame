using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{
    float timer = 0f, delaytime = 1f;
    private void OnTriggerEnter(Collider other)
    {
        Life life = other.GetComponent<Life>();
        if (life != null && life.amount > 0)
        {
            life.amount -= 1;
            print("damager");
            StartCoroutine(Delay());
        }
    }
    IEnumerator Delay()
    {
        yield return new WaitForSecondsRealtime(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
