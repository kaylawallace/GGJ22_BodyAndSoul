using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
    public float speed = 15f;
    public Rigidbody rb;
    public GameObject hitEffect;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();

        if (enemy)
        {
            enemy.TakeDamage(1);
        }
        GameObject hit = Instantiate(hitEffect, gameObject.transform.position, gameObject.transform.rotation);
        Destroy(gameObject);
        Destroy(hit, 1f);
    }
}
