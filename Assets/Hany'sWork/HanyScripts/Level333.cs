using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UI;

public class Level333 : MonoBehaviour
{
     public Image circle;

    private void Awake()
    {
        circle.transform.localScale = Vector3.zero;
    }
    private void Start()
    {
       circle.enabled = true;
StartCoroutine(CircleIncrease());
    }

    private void Update()
    {
       
    }



    public IEnumerator CircleIncrease()
    {

        while (circle.transform.localScale.x <= 7)
        {
            Vector3 current = circle.transform.localScale;
            float scale = 0.3f;
            Vector3 newScale = new Vector3(current.x + scale, current.y + scale, current.z);
            circle.transform.localScale = newScale;
            yield return new WaitForSeconds(.1f);

        }

        yield return new WaitForSeconds(1);
         
        StartCoroutine(CircleDecrease());
        
    }

    public IEnumerator CircleDecrease()
    {

        while (circle.transform.localScale.x >=0)
        {
            Vector3 current = circle.transform.localScale;
            float scale = 0.3f;
            Vector3 newScale = new Vector3(current.x - scale, current.y - scale, current.z);
            circle.transform.localScale = newScale;
            yield return new WaitForSeconds(.1f);
        }
    }




}


