using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class BodyController : MonoBehaviour
{
    [SerializeField] public float speed = 2.0f;
    [SerializeField] private float jumpHeight = 1.0f;
    [SerializeField] private float gravity = -9.81f;

    private CharacterController controller;
    private Vector3 vel;
    private bool grounded;
    private Vector2 movInput = Vector2.zero;
    private bool jumped = false;
    private bool facingRight = true;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        grounded = controller.isGrounded;
        if (grounded && vel.y < 0)
        {
            vel.y = 0f;
        }

        Vector3 move = new Vector3(movInput.x, 0, movInput.y);
        controller.Move(move * Time.deltaTime * speed);

        if (movInput.x == 1 && !facingRight)
        {
            Flip();
        }
        else if (movInput.x == -1 && facingRight)
        {
            Flip();
        }

        // Changes the height position of the player..
        if (jumped && grounded)
        {
            vel.y += Mathf.Sqrt(jumpHeight * -3.0f * gravity);
        }

        vel.y += gravity * Time.deltaTime;
        controller.Move(vel * Time.deltaTime);       
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movInput = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        jumped = context.action.triggered;
    }

    private void Flip()
    {
        facingRight = !facingRight; 
        transform.Rotate(0, 180, 0);
    }
}
