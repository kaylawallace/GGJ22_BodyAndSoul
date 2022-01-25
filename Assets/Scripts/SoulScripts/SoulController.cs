using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class SoulController : MonoBehaviour
{
    [SerializeField] private float speed = 2.0f;

    //private CharacterController controller;
    private Rigidbody rb;
    private Vector2 movInput = Vector2.zero;

    private void Start()
    {
        //controller = gameObject.GetComponent<CharacterController>();
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 move = new Vector3(movInput.x, movInput.y, 0);
        rb.AddForce(move * speed);
        //controller.Move(move * Time.deltaTime * speed);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movInput = context.ReadValue<Vector2>();
    }
}
