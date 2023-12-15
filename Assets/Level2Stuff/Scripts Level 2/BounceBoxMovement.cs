using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class BounceBoxMovement : MonoBehaviour
{
    public float speed;
    private float rotSpeed;
    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddRelativeForce(0, -speed * rb.transform.position.x * Time.deltaTime, speed * rb.transform.position.z * Time.deltaTime);
    }
}
