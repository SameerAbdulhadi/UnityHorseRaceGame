using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class move : MonoBehaviour
{
    Animator anim;
    public float speed;
    public float halfSpeed;    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
        speed = 850f;
        halfSpeed = 180f;
    }

    // Update is called once per frame
    void Update()
    {
        HorseMovesKeysUp();
        HorseMovesKeysDown();
        HorseRotation();
        HorseJump();
    }

private void HorseMovesKeysDown()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed * Time.deltaTime );
            anim.SetBool("MoveForward", true);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0,- halfSpeed * Time.deltaTime);
            anim.SetBool("MoveBackward", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate( halfSpeed * Time.deltaTime , 0, 0);
            anim.SetBool("MoveRight", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(- halfSpeed * Time.deltaTime , 0, 0);
            anim.SetBool("MoveLeft", true);
        }

    }

    private void HorseMovesKeysUp()
    {
            anim.SetBool("MoveForward", false);
            anim.SetBool("MoveBackward", false);
            anim.SetBool("MoveRight", false);
            anim.SetBool("MoveLeft", false);
            anim.SetBool("Jump", false);
    }

    private void HorseRotation()
    { 
        transform.Rotate(0,Input.GetAxis("Horizontal") *halfSpeed * Time.deltaTime , 0);
    }

    private void HorseJump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("Jump", true);
        }
    }



}
