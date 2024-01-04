using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class VolcanoMapInputSystem : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float jumpForce;
    public float jumpAnimationDuration = 0.5f;
    private Vector2 movementValue;
    private float lookValue;
    public float c;
    public Collider HorseCollider;
    private Rigidbody rb;
    private Animator anim;
    private Coroutine jumpCoroutine;
    public int horseLives = 3;
    public GameObject playerLivesImages;
    public void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //rb.AddRelativeTorque(0, lookValue * Time.deltaTime, 0);
        HorseRotation();
       
        rb.AddRelativeForce(movementValue.x, 0, movementValue.y);

    }
    public void OnMove(InputValue value)
    {
        // Use only the vertical input for forward and backward movement
       
            movementValue = new Vector2(0, value.Get<Vector2>().y) * speed;
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

    private void HorseRotation()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime, 0);
    }

    

}
