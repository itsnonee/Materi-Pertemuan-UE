using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform target;

    void Update()
    {
        // Kejar player
        agent.SetDestination(target.position);
    }
}
