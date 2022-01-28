using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpellCast : MonoBehaviour
{
    private bool cast;
    public Transform firePoint;
    public GameObject orbPrefab;

    private bool cooling; 

    // Update is called once per frame
    void Update()
    {
        if (cast && !cooling)
        {
            Cast();
            StartCoroutine(Cooldown(1));
        }
    }

    public void OnCast(InputAction.CallbackContext context)
    {
        cast = context.action.triggered;
    }

    public void Cast()
    {       
        Instantiate(orbPrefab, firePoint.position, firePoint.rotation);
        cast = false;
    }

    IEnumerator Cooldown(float cooldownTime)
    {
        cooling = true;
        yield return new WaitForSeconds(cooldownTime);
        cooling = false;
    }
}
