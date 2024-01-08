using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class InputSystem : MonoBehaviour
{
    public float rotationSpeed;
    public float baseSpeed;
    public float maxSpeed;
    public float currentSpeed;
    public float accelerationRate;

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
        if (SceneManager.GetActiveScene().name == "HorseSelection")
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            this.enabled = false;
        }
        else
        {
            this.enabled = true;
        }
            rb.AddRelativeTorque(0, lookValue * Time.deltaTime, 0);
        rb.AddRelativeForce(movementValue.x * currentSpeed * Time.deltaTime, 0, movementValue.y * currentSpeed * Time.deltaTime);

    }

    public void OnMove(InputValue value)
    {

        movementValue = value.Get<Vector2>() * currentSpeed;

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
    int count = 0;
    //if(SceneManager.GetActiveScene().name = "Level_1"){

      //  }
    IEnumerator ResetJumpAnimation()
    {
        // Reset jump animation after a delay
        yield return new WaitForSeconds(jumpAnimationDuration);
        anim.SetBool("Jump", false);
    }




    public void OnSpeedUp(InputValue value)
    {

        if (value.isPressed)
        {
            currentSpeed = currentSpeed * accelerationRate;
            currentSpeed = Mathf.Clamp(currentSpeed, baseSpeed, maxSpeed); // Clamp the speed to be within the specified range
            StartCoroutine(DecreaseSpeedAfterDelay());
        }

        // Start a coroutine to decrease speed after a delay when the button is released


    }

    IEnumerator DecreaseSpeedAfterDelay()
    {
        yield return new WaitForSeconds(3);

        // Gradually decrease speed back to baseSpeed
        while (currentSpeed > baseSpeed)
        {
            yield return new WaitForSeconds(4);

            currentSpeed /= accelerationRate;


            yield return null;
        }

        currentSpeed = baseSpeed;
    }











    void UpdateAnimation()
    {

        anim.SetBool("MoveForward", movementValue.y > 0);
        anim.SetBool("MoveBackward", movementValue.y < 0);
        anim.SetBool("MoveRight", movementValue.x > 0);
        anim.SetBool("MoveLeft", movementValue.x < 0);
    }
}
