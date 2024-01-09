using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesManager : MonoBehaviour
{
    Life life;
    bool restart = true;
    Rigidbody rb;
    GameObject child, child1, child2; // child is maincamera, child1 is canvas, child 2 is losescene
    // Start is called before the first frame update
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        child = gameObject.transform.GetChild(10).gameObject;
        child1 = child.transform.GetChild(0).gameObject;
        child2 = child1.transform.GetChild(1).gameObject;
        life = gameObject.GetComponent<Life>();
        child2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (life.amount <= 0 && restart)
        {
            //rb.Sleep();
            restart = false;
            child2.SetActive(true);
            StartCoroutine(Delay());
            if (gameObject.tag == "BrownHorse")
                scoreToBoard.instance.brownScore -= 200; //score decrease
            else if (gameObject.tag == "BlackHorse")
                score2ToBoard.instance.blackScore -= 200;
        }
    }
    void Restart()
    {
        life.amount = 3;
        child2.SetActive(false);
        //print("restart");
        restart = true;
        //rb.WakeUp();
    }
    IEnumerator Delay()
    {
        //print("waiting");
        yield return new WaitForSeconds(5f);
        Restart();
    }
}
