using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayers : MonoBehaviour
{
    public Transform spawnPoint; 
    public int maxHealth = 1;
    [SerializeField]private int health;
    private GameObject other;
    private Vector3 soulSpawnPosOffset = new Vector3(-2f, 1.5f, 0f);
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        if (gameObject.GetComponent<BodyController>())
        {
            anim = gameObject.GetComponent<BodyController>().animController;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") || other.CompareTag("Hazard")) {
            TakeDamage(1);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Death();
            StartCoroutine(RespawnTime(2.5f));
        }
    }

    public void Death()
    {
        if (gameObject.name == "Body")
        { 
            other = GameObject.Find("Soul");
            anim.SetTrigger("Death");
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
    }

    public void Respawn()
    {
        if (gameObject.name == "Body")
        {
            gameObject.GetComponent<CharacterController>().enabled = false; 

            gameObject.transform.position = spawnPoint.position;
            other.transform.position = spawnPoint.position + soulSpawnPosOffset;

            //gameObject.GetComponent<MeshRenderer>().enabled = true;
            //other.GetComponent<MeshRenderer>().enabled = true;

            health = maxHealth;
            other.GetComponent<RespawnPlayers>().health = maxHealth;

            gameObject.GetComponent<CharacterController>().enabled = true;

            other.GetComponent<SoulController>().enabled = true;
            gameObject.GetComponent<BodyController>().enabled = true;

            anim.SetInteger("AnimState", 0);
        }
        
        else if (gameObject.CompareTag("Soul"))
        {
            other.GetComponent<CharacterController>().enabled = false;

            gameObject.transform.position = spawnPoint.position + soulSpawnPosOffset;
            other.transform.position = spawnPoint.position;

            //gameObject.GetComponent<MeshRenderer>().enabled = true;
            //other.GetComponent<MeshRenderer>().enabled = true;

            health = maxHealth;
            other.GetComponent<RespawnPlayers>().health = maxHealth;

            other.GetComponent<CharacterController>().enabled = true;

            other.GetComponent<BodyController>().enabled = true;
            gameObject.GetComponent<SoulController>().enabled = true;
        }
    }

    IEnumerator RespawnTime(float respawnTime)
    {
        yield return new WaitForSeconds(respawnTime);
        Respawn();
    }
}
