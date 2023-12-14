using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanyHitObstacles : MonoBehaviour
{
    private void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Horse")
        {
          
            
            CallTheSpeedReduction(other.gameObject);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        
    }

    private void CallTheSpeedReduction(GameObject horseGameObject)
    {
        Hanymove moveScriptInstance = horseGameObject.GetComponent<Hanymove>();

        if (moveScriptInstance != null)
        {
            StartCoroutine(ReduceSpeedIfCollided(moveScriptInstance, 1));
        }

    } 

        IEnumerator ReduceSpeedIfCollided(Hanymove moveScriptInstance, float duration)
    {
        if (moveScriptInstance != null)
        {
            float originalSpeed = moveScriptInstance.speed;

            if (moveScriptInstance.speed >=501)
            {
                moveScriptInstance.speed = moveScriptInstance.speed / 2;

                yield return new WaitForSeconds(duration);

                moveScriptInstance.speed = originalSpeed;
            }
        }
    }
}