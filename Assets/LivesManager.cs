using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesManager : MonoBehaviour
{
    Life life;
    GameObject child, child1, child2; // child is maincamera, child1 is canvas, child 2 is losescene
    // Start is called before the first frame update
    void Start()
    {
        child = gameObject.transform.GetChild(10).gameObject;
        child1 = child.transform.GetChild(0).gameObject;
        child2 = child1.transform.GetChild(1).gameObject;
        life = gameObject.GetComponent<Life>();
        child2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (life.amount <= 0)
            child2.SetActive(true);
    }
}
