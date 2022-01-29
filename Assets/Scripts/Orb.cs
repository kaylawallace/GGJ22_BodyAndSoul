using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
    public float speed = 15f;
    public Rigidbody rb;
    public GameObject hitEffect;

    private float size = .1f, freq = 10f;
    private Vector3 axis;
    private Vector3 pos;
    
    // Start is called before the first frame update
    void Start()
    {
        axis = transform.up;
        pos = transform.position;
    }

    private void Update()
    {
        pos += transform.right * Time.deltaTime * speed;
        transform.position = pos + axis * Mathf.Sin(Time.time * freq) * size;
    }

    private void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();

        if (enemy)
        {
            enemy.TakeDamage(1);
        }       
        else if (other.CompareTag("Destructable"))
        {
            Destroy(other.gameObject);
        }

        GameObject hit = Instantiate(hitEffect, gameObject.transform.position, gameObject.transform.rotation);
        Destroy(gameObject);
        Destroy(hit, 1f);
    }
}
