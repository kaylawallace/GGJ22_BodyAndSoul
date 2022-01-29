using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Body") || other.CompareTag("Soul"))
        {
            print("ceiling falling");
            gameObject.GetComponentInParent<Rigidbody>().useGravity = true;
        }
    }
}
