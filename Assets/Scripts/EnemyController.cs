using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public NavMeshAgent agent;
    public float range = 3f;

    public LayerMask playerMask;
    public GameObject player;

    void Update()
    {
        bool playerInRange = Physics.CheckSphere(transform.position, range, playerMask);

        if (playerInRange) 
        {
            agent.SetDestination(player.transform.position);
        }
    }

}
