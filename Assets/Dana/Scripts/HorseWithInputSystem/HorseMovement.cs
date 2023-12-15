using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseMovement : MonoBehaviour
{
    private Animator anim;
    public float speed , rotationSpeed=20;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetInteger("Speed", 1);
        anim.SetBool("Jump", false);
        anim.SetBool("Run", false);
        HorseJump(); 
        HorseWalk();
        HorseRotation();
    }


    private void HorseJump()
    {
        
        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("Jump", true);
        }
    }

    private void HorseWalk()
    {
        if (Input.GetKey(KeyCode.W))
        {
            speed = 0.4f;
            anim.SetBool("Run", true);
            transform.Translate(0, 0, speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            speed = 0.65f;
            anim.SetBool("Run", true);
            anim.SetInteger("Speed", -1);
            transform.Translate(0, 0, -speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            speed = 0.35f;
            anim.SetBool("Run", true);
            transform.Translate(speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            speed = 0.35f;
            anim.SetBool("Run", true);
            transform.Translate(-speed, 0, 0);
        }
    }
    private void HorseRotation()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") , 0);
    }
}
