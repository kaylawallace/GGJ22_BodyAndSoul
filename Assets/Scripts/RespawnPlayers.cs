using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayers : MonoBehaviour
{
    public Transform spawnPoint; 
    public int maxHealth = 1;
    [SerializeField]private int health;
    private Vector3 soulSpawnPosOffset = new Vector3(-2f, 1.5f, 0f);
    private Animator anim;
    private bool _dead;
    private GameObject body, soul, line, cam;
    private SkinnedMeshRenderer[] sRenderers;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        body = GameObject.Find("Body");
        soul = GameObject.Find("Soul");
        line = GameObject.Find("Line");
        cam = GameObject.Find("Main Camera");

        anim = body.GetComponent<BodyController>().animController;
        _dead = body.GetComponent<BodyController>().dead;
        sRenderers = soul.GetComponent<SoulController>().renderers;
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
            if (!_dead)
            {
                _dead = true;
                anim.SetTrigger("Death");

                for (int i = 0; i < sRenderers.Length; i++)
                {
                    sRenderers[i].enabled = false;
                }

                line.GetComponent<LineRenderer>().enabled = false; 

                Invoke("Death", 2.8f);
                StartCoroutine(RespawnTime(2.8f));
            }
        }
    }

    public void Death()
    {
        body.GetComponent<BodyController>().enabled = false;
        soul.GetComponent<SoulController>().enabled = false;
        body.GetComponent<Transform>().parent = null;
        soul.GetComponent<SoulController>().Unpossess();
    }

    public void Respawn()
    {
        anim.SetInteger("AnimState", 0);

        body.transform.position = spawnPoint.position;
        soul.transform.position = spawnPoint.position + soulSpawnPosOffset;

        health = maxHealth;

        body.GetComponent<BodyController>().enabled = true;
        soul.GetComponent<SoulController>().enabled = true;

        for (int i = 0; i < sRenderers.Length; i++)
        {
            sRenderers[i].enabled = true;
        }

        line.GetComponent<LineRenderer>().enabled = true;

        _dead = false; 
    }

    IEnumerator RespawnTime(float respawnTime)
    {
        yield return new WaitForSeconds(respawnTime);
        Respawn();
    }
}
