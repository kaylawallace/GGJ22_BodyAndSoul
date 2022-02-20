using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class SoulController : MonoBehaviour
{
    public float speed = 4.0f, possessSpeed = 15.0f;
    public float dashSpeed;
    public float startDashTime;
    public float dashCooldown;
    public SkinnedMeshRenderer[] renderers = new SkinnedMeshRenderer[5];

    private Rigidbody rb;
    private Vector2 movInput = Vector2.zero;
    private Transform toPossess;
    private Platform p;
    private GameObject body;
    private float mass; 

    private bool possessed;
    private bool unpossessed;
    public bool possessing;
    private bool inRange;
    private bool facingRight = true;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        body = GameObject.Find("Body");
        mass = rb.mass; 
    }

    void Update()
    {
        //Move();

        if (possessed)
        {
            Possess();
        }

        if (unpossessed)
        {
            Unpossess();
        }
    }

    private void FixedUpdate()
    {
        Move();
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
            rb.mass = 3;
            rb.drag = 5;
            speed = possessSpeed;
            //gameObject.GetComponent<MeshRenderer>().enabled = false;
            //body.transform.parent = transform;

            for (int i = 0; i < renderers.Length; i++)
            {
                renderers[i].enabled = false; 
            }
            

            if (p.limitToX)
            {
                rb.constraints |= RigidbodyConstraints.FreezePositionY;
            }
            else if (p.limitToY)
            {
                rb.constraints |= RigidbodyConstraints.FreezePositionX;
            }
            
            if (p.usesGravity)
            {
                Rigidbody temp = p.gameObject.GetComponent<Rigidbody>();
                if (temp)
                {
                    Destroy(p.gameObject.GetComponent<Rigidbody>());
                }
            }

            if (p.controlsAnother)
            {
                p.anotherToControl.transform.parent = transform;
            }

            possessing = true;
        }
    }

    public void Unpossess()
    {
        if (possessing)
        {
           
            if (toPossess)
            {
                toPossess.parent = null;
            }
            //body.transform.parent = null;
            //gameObject.GetComponent<MeshRenderer>().enabled = true;
            for (int i = 0; i < renderers.Length; i++)
            {
                renderers[i].enabled = true;
            }

            rb.constraints = RigidbodyConstraints.None;
            rb.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ;

            Platform temp = gameObject.GetComponentInChildren<Platform>();
            if (temp)
            {
                print(temp.gameObject.name);
                temp.gameObject.transform.parent = null;
            }

            if (p)
            {
                if (p.usesGravity)
                {
                    p.gameObject.AddComponent<Rigidbody>();
                    p.gameObject.GetComponent<Rigidbody>().useGravity = true;
                }
                if (p.controlsAnother)
                {
                    p.anotherToControl.transform.parent = null;
                    
                    temp = gameObject.GetComponentInChildren<Platform>();
                    if (temp)
                    {
                        gameObject.GetComponentInChildren<Platform>().transform.parent = null;
                        Destroy(temp);
                    }
                }
            }

            rb.mass = mass;
            rb.drag = 3.5f;
            speed = 3;
            possessing = false;
        }
    }

    IEnumerator Cooldown(float cooldownTime)
    {
        yield return new WaitForSeconds(cooldownTime);
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
