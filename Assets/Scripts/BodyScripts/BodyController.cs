using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//[RequireComponent(typeof(CharacterController))]
public class BodyController : MonoBehaviour
{
    [SerializeField] public float speed = 2.0f;
    [SerializeField] private float jumpHeight = 1.0f;
    [SerializeField] private float gravity = -9.81f;
    public float platformOffset; 
    public Animator animController;
    public float checkRadius;
    public Transform feetPos;
    public LayerMask whatIsGround, whatIsPlatform;

    private CharacterController controller;
    private Rigidbody rb;
    private Vector3 vel;
    private bool grounded;
    private Vector2 movInput = Vector2.zero;
    private bool jumped = false;
    private bool facingRight = true;
    private GameObject soul;
    [HideInInspector]public bool dead; 


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        soul = GameObject.Find("Soul");
        dead = false;
    }

    void Update()
    {
        if (!dead)
        {
            grounded = isGrounded();
            if (grounded && vel.y < 0)
            {
                vel.y = 0f;
            }

            Jump();

            isOnPlatform();
        }
    }

    private void FixedUpdate()
    {
        if (!dead)
        {
            Move();
        }      
    }

    public void Move()
    {
        Vector3 move = new Vector3(movInput.x, 0, movInput.y);
        rb.velocity = new Vector3(move.x * speed, vel.y, move.z * speed);

        if (movInput.x == 1 && !facingRight)
        {
            Flip();
        }
        else if (movInput.x == -1 && facingRight)
        {
            Flip();
        }

        if (movInput != Vector2.zero)
        {
            animController.SetInteger("AnimState", 1);
        }
        else
        {
            animController.SetInteger("AnimState", 0);
        }

    }

    public void Jump()
    {
        if (jumped && isGrounded())
        {
            vel = Vector3.up * jumpHeight;
        }

        if (vel.y > 0)
        {
            animController.SetInteger("AnimState", 2);
        }
        else if (vel.y < 0)
        {
            animController.SetInteger("AnimState", 3);
        }


        vel.y += gravity * Time.deltaTime;
        rb.velocity = vel * Time.deltaTime;
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

    public bool isGrounded()
    {
        bool _grounded = Physics.CheckSphere(feetPos.position, checkRadius, whatIsGround);
        return _grounded;
    }

    public bool isOnPlatform()
    {
        bool _onPlatform = false;
        Collider[] colliders = Physics.OverlapSphere(feetPos.position, checkRadius, whatIsPlatform);

        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].CompareTag("Platform"))
            {
                transform.parent = colliders[i].transform;
                _onPlatform = true;

                if (!jumped)
                {
                    transform.position = new Vector3(transform.position.x, colliders[i].transform.position.y + platformOffset, transform.position.z);
                }
            }
            else
            {
                transform.parent = null;
                _onPlatform = false; 
            }
        }
        return _onPlatform; 
    }
}
