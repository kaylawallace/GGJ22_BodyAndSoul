using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrolling : MonoBehaviour
{
    [SerializeField] private GameObject[] points;
    [SerializeField] private NavMeshAgent agent;

    private int currPoint;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = true;
        //agent.baseOffset = 1f;
        //agent.height = 1f;
        currPoint = 0;
        agent.destination = points[currPoint].transform.position;
    }

    private void Update()
    {
        if (Vector3.Distance(this.transform.position, points[currPoint].transform.position) <= 1f) 
        {
            Iterate();
        }
    }

    public void Iterate()
    {
        if (currPoint == 0)
        {
            currPoint = 1;
        }
        else if (currPoint == 1)
        {
            currPoint = 0;
        }

        agent.destination = points[currPoint].transform.position;
    }
}
