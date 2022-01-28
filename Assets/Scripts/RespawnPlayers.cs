using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayers : MonoBehaviour
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
        if (other.CompareTag("Enemy") || other.CompareTag("Hazard")) {
            TakeDamage(1);
        }
    }

    public void TakeDamage(int damage)
    {

    }
}
