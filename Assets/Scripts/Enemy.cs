using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent agent; // Enemy
    public Transform target; // Player

    void Update()
    {
        // Membuat Enemy mengejar Player
        agent.SetDestination(target.position);
    }
}
