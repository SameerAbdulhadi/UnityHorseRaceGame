using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class InputSystem : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float jumpForce;
    public float jumpAnimationDuration = 0.5f; 
    private Vector2 movementValue;
    private float lookValue;

    public  Rigidbody rb;
    private Animator anim;

    private Coroutine jumpCoroutine;

    public void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        rb.AddRelativeTorque(0, lookValue * Time.deltaTime, 0);
        rb.AddRelativeForce(movementValue.x * Time.deltaTime, 0, movementValue.y * Time.deltaTime);
    }

    public void OnMove(InputValue value)
    {
        movementValue = value.Get<Vector2>() * speed;
        UpdateAnimation();
    }

    public void OnLook(InputValue value)
    {
        lookValue = value.Get<Vector2>().x * rotationSpeed;
    }

    public void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            anim.SetBool("Jump", true);
            if (jumpCoroutine != null)
            {
                StopCoroutine(jumpCoroutine);
            }
            jumpCoroutine = StartCoroutine(ResetJumpAnimation());
        }
    }

    IEnumerator ResetJumpAnimation()
    {
        yield return new WaitForSeconds(jumpAnimationDuration);
        anim.SetBool("Jump", false);
    }

    void UpdateAnimation()
    {
        anim.SetBool("MoveForward", movementValue.y > 0);
        anim.SetBool("MoveBackward", movementValue.y < 0);
        anim.SetBool("MoveRight", movementValue.x > 0);
        anim.SetBool("MoveLeft", movementValue.x < 0);
    }
}
