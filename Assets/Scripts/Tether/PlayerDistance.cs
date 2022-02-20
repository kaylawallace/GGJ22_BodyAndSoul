using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDistance : MonoBehaviour
{
    public float maxDist;
    float dist = 0f;
    GameObject body, soul;
    SoulController sController;
    Vector3 bPos, sPos;
    float bSpeed, sSpeed, sPossessSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        body = GameObject.FindGameObjectWithTag("Body");
        soul = GameObject.FindGameObjectWithTag("Soul");
        bSpeed = body.GetComponent<BodyController>().speed;
        sSpeed = soul.GetComponent<SoulController>().speed;
        sPossessSpeed = soul.GetComponent<SoulController>().possessSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        bPos = body.transform.position;
        sPos = soul.transform.position;
        

        dist = Vector3.Distance(bPos, sPos);
        if (dist >= maxDist)
        {
            dist = 0;
            body.GetComponent<RespawnPlayers>().TakeDamage(1);
        }
        else if (dist > (maxDist / 2) && dist < maxDist)
        {
            if (body.GetComponent<BodyController>().speed <= bSpeed / 2)
            {
                body.GetComponent<BodyController>().speed = bSpeed / 2;
            }
            if (soul.GetComponent<SoulController>().speed <= sSpeed / 2)
            {
                soul.GetComponent<SoulController>().speed = sSpeed / 2;
            }

            body.GetComponent<BodyController>().speed -= .01f;
            soul.GetComponent<SoulController>().speed -= .01f;
        }
        else
        {
            if (body.GetComponent<BodyController>().speed != bSpeed)
            {
                body.GetComponent<BodyController>().speed = bSpeed;
            }
            if (soul.GetComponent<SoulController>().speed != sSpeed && soul.GetComponent<SoulController>().speed != sPossessSpeed)
            {
                if (soul.GetComponent<SoulController>().possessing)
                {
                    soul.GetComponent<SoulController>().speed = sPossessSpeed;
                }
                else
                {
                    soul.GetComponent<SoulController>().speed = sSpeed;
                }              
            }
        }     
    }
}
