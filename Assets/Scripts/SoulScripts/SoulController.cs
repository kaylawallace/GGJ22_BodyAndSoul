using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class SoulController : MonoBehaviour
{
    public float speed = 2.0f;
    public float dashSpeed;
    public float startDashTime;
    public float dashCooldown;

    private Rigidbody rb;
    private Vector2 movInput = Vector2.zero;
    private Transform toPossess;
    private float dashTime;
    private Platform p;

    private bool possessed;
    private bool unpossessed;
    private bool possessing;
    private bool inRange;
    private bool dashed;
    private bool cooling;
    private bool facingRight = true;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

        dashTime = startDashTime;
    }

    void Update()
    {
        Move();

        if (possessed)
        {
            Possess();
        }

        if (unpossessed)
        {
            Unpossess();
        }

        if (dashed && !cooling)
        {
            Dash();
            StartCoroutine(Cooldown(2f));
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movInput = context.ReadValue<Vector2>();       
    }

    public void OnPossess(InputAction.CallbackContext context)
    {
        possessed = context.action.triggered;
    }

    public void OnUnpossess(InputAction.CallbackContext context)
    {
        unpossessed = context.action.triggered;
    }

    public void OnDash(InputAction.CallbackContext context)
    {
        dashed = context.action.triggered;
    }

    public void Move()
    {
        Vector3 move = new Vector3(movInput.x, movInput.y, 0);
        rb.AddForce(move * speed);

        if (movInput.x == 1 && !facingRight && !possessing)
        {
            Flip();
        }
        else if (movInput.x == -1 && facingRight && !possessing)
        {
            Flip();
        }
    }

    public void Possess()
    {
        if (inRange && p)
        {
            toPossess.parent = transform;
            gameObject.GetComponent<MeshRenderer>().enabled = false;             

            if (p.limitToX)
            {
                rb.constraints |= RigidbodyConstraints.FreezePositionY;
            }
            else if (p.limitToY)
            {
                rb.constraints |= RigidbodyConstraints.FreezePositionX;
            }

            possessing = true;
        }
    }

    public void Unpossess()
    {
        if (possessing && p)
        {
            toPossess.parent = null;
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            
            if (p.limitToX)
            {
                rb.constraints = RigidbodyConstraints.None;                
                rb.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ;
            }
            else if (p.limitToY)
            {
                rb.constraints = RigidbodyConstraints.None;
                rb.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ;
            }

            possessing = false;
        }
    }

    public void Dash()
    {
        if (dashTime <= 0)
        {
            dashTime = startDashTime;
            rb.velocity = Vector3.zero;
        }
        else
        {
            dashTime -= Time.deltaTime;
            rb.velocity = new Vector3(movInput.x, movInput.y, 0) * dashSpeed;
        }
    }

    IEnumerator Cooldown(float cooldownTime)
    {
        cooling = true;
        yield return new WaitForSeconds(cooldownTime);
        cooling = false; 
    }

    private void OnTriggerEnter(Collider other)
    {
        p = other.GetComponent<Platform>();
        if (p)
        {
            inRange = true;
            toPossess = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Platform"))
        {
            inRange = false;
            toPossess = null;          
        }
    }

    private void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
    }
}
