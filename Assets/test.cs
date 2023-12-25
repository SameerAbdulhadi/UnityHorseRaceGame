using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class MoveWithCollider : MonoBehaviour
{
    Animator anim;
    CharacterController characterController;
    Camera mainCamera;

    public float speed = 5f;
    public float rotationSpeed = 10f;
    public float jumpForce = 10f;
    public float gravity = 30f;

    private Vector3 velocity;
    private bool isGrounded;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
        mainCamera = Camera.main;

        // Lock and hide the cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        HandleMovement();
        HandleJump();
    }

    private void HandleMovement()
    {
        Vector2 movementInput = new Vector2(
            Keyboard.current.dKey.isPressed ? 1 : Keyboard.current.aKey.isPressed ? -1 : 0,
            Keyboard.current.wKey.isPressed ? 1 : Keyboard.current.sKey.isPressed ? -1 : 0
        );

        Vector3 forward = mainCamera.transform.forward;
        Vector3 right = mainCamera.transform.right;

        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();

        Vector3 desiredMoveDirection = forward * movementInput.y + right * movementInput.x;

        if (desiredMoveDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(desiredMoveDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

        float targetSpeed = speed * movementInput.magnitude;
        velocity = transform.TransformDirection(Vector3.forward) * targetSpeed;

        anim.SetFloat("Speed", targetSpeed);
    }

    private void HandleJump()
    {
        isGrounded = characterController.isGrounded;

        if (isGrounded && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            velocity.y = Mathf.Sqrt(2f * jumpForce * gravity);
            anim.SetBool("Jump", true);
        }
        else
        {
            anim.SetBool("Jump", false);
        }

        if (!isGrounded)
        {
            velocity.y -= gravity * Time.deltaTime;
        }

        characterController.Move(velocity * Time.deltaTime);
    }
}
