using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class InputSystem : MonoBehaviour
{
    public float rotationSpeed;
    public float baseSpeed;
    public float maxSpeed;
    public float currentSpeed;

    private Vector2 movementValue;
    private float lookValue;

    private Rigidbody rb;
    private Animator anim;
    private Coroutine jumpCoroutine;
    public float jumpAnimationDuration;

    public void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        currentSpeed = baseSpeed;
    }

    void Update()
    {

        rb.AddRelativeTorque(0, lookValue * Time.deltaTime, 0);
        rb.AddRelativeForce(movementValue.x * currentSpeed * Time.deltaTime, 0, movementValue.y * currentSpeed * Time.deltaTime);
    }

    public void OnMove(InputValue value)
    {

        movementValue = value.Get<Vector2>() * currentSpeed;

        // Update animation based on movement
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
            // Trigger jump animation and reset after a delay
            anim.SetBool("Jump", true);

            if (jumpCoroutine != null)
            {
                StopCoroutine(jumpCoroutine);
            }
            jumpCoroutine = StartCoroutine(ResetJumpAnimation());
        }
    }

    public void OnSpeedUp(InputValue value)
    {
        if (value.isPressed)
        {
            currentSpeed += 5*Time.deltaTime; // Increase speed over time while the button is pressed

            // Clamp speed to a maximum value
            currentSpeed = Mathf.Clamp(currentSpeed, baseSpeed, maxSpeed);
        }
        else
        {
            // Reset speed when the button is released
            currentSpeed = baseSpeed;
        }
    }

    IEnumerator ResetJumpAnimation()
    {
        // Reset jump animation after a delay
        yield return new WaitForSeconds(jumpAnimationDuration);
        anim.SetBool("Jump", false);
    }

    void UpdateAnimation()
    {
        // Update animation based on movement direction
        anim.SetBool("MoveForward", movementValue.y > 0);
        anim.SetBool("MoveBackward", movementValue.y < 0);
        anim.SetBool("MoveRight", movementValue.x > 0);
        anim.SetBool("MoveLeft", movementValue.x < 0);
    }
}
