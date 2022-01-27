using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpellCast : MonoBehaviour
{
    private bool cast;
    public Transform firePoint;
    public GameObject orbPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cast)
        {
            Cast();
        }
    }

    public void OnCast(InputAction.CallbackContext context)
    {
        cast = context.action.triggered;
    }

    public void Cast()
    {       
        Instantiate(orbPrefab, firePoint.position, Quaternion.identity);
        cast = false;
    }
}
