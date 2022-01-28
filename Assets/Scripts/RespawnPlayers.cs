using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayers : MonoBehaviour
{
    public Transform spawnPoint; 
    public int maxHealth = 1;
    [SerializeField]private int health;
    private bool cooling;
    private GameObject other;
    private Vector3 soulSpawnPosOffset = new Vector3(-1, 1, 0);

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy")) {
            //print("collision");
            TakeDamage(1);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Death();

            //if (!cooling)
            //{
                Respawn();
            //}
        }
    }

    public void Death()
    {
        if (gameObject.name == "Body")
        { 
            other = GameObject.Find("Soul");
            gameObject.GetComponent<BodyController>().enabled = false;
            other.GetComponent<SoulController>().enabled = false;
        }
        else if (gameObject.CompareTag("Soul"))
        {
            other = GameObject.Find("Body");
            other.GetComponent<BodyController>().enabled = false;
            gameObject.GetComponent<SoulController>().enabled = false; 

        }
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        other.GetComponent<MeshRenderer>().enabled = false;
        //StartCoroutine(RespawnTime(2f));
    }

    public void Respawn()
    {
        if (gameObject.name == "Body")
        {
            gameObject.GetComponent<CharacterController>().enabled = false; 

            gameObject.transform.position = spawnPoint.position;
            other.transform.position = spawnPoint.position + soulSpawnPosOffset;

            gameObject.GetComponent<MeshRenderer>().enabled = true;
            other.GetComponent<MeshRenderer>().enabled = true;

            health = maxHealth;
            other.GetComponent<RespawnPlayers>().health = maxHealth;

            gameObject.GetComponent<CharacterController>().enabled = true;

            other.GetComponent<SoulController>().enabled = true;
            gameObject.GetComponent<BodyController>().enabled = true;

        }
        
        else if (gameObject.CompareTag("Soul"))
        {
            other.GetComponent<CharacterController>().enabled = false;

            gameObject.transform.position = spawnPoint.position + soulSpawnPosOffset;
            other.transform.position = spawnPoint.position;

            gameObject.GetComponent<MeshRenderer>().enabled = true;
            other.GetComponent<MeshRenderer>().enabled = true;

            health = maxHealth;
            other.GetComponent<RespawnPlayers>().health = maxHealth;

            other.GetComponent<CharacterController>().enabled = true;

            other.GetComponent<SoulController>().enabled = true;
            gameObject.GetComponent<BodyController>().enabled = true;
        }
    }

    IEnumerator RespawnTime(float respawnTime)
    {
        cooling = true;
        yield return new WaitForSeconds(respawnTime);
        cooling = false;
    }
}
