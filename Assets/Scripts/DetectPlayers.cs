using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayers : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Body") || other.CompareTag("Soul"))
        {
            gameObject.GetComponentInParent<Rigidbody>().useGravity = true;
        }
    }
}
