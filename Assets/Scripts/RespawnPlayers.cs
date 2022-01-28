using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayers : MonoBehaviour
{
    public Transform spawnPoint; 
    public int maxHealth = 1;
    [SerializeField]private int health;
    private bool cooling;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy")) {
            print("collision");
            TakeDamage(1);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Death();
            
            if (!cooling)
            {
                Respawn();
            }           
        }
    }

    public void Death()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        StartCoroutine(RespawnTime(2f));
    }

    public void Respawn()
    {
        if (gameObject.CompareTag("Body"))
        {
            print("body");
            gameObject.transform.position = new Vector3(spawnPoint.position.x, spawnPoint.position.y, spawnPoint.position.z);
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            health = maxHealth;
        }
        
        if (gameObject.CompareTag("Soul"))
        {
            gameObject.transform.position = new Vector3(spawnPoint.position.x - 1, spawnPoint.position.y + 1, spawnPoint.position.z);
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            health = maxHealth;
        }
    }

    IEnumerator RespawnTime(float respawnTime)
    {
        cooling = true;
        yield return new WaitForSeconds(respawnTime);
        cooling = false;
    }
}
