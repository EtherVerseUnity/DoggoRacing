using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AnimalController : MonoBehaviour
{
    public float speed = 3.5f;
    public float rotationSpeed = 120.0f;
    public float jumpPower = 5.0f;
    public Animator animator;
    private NavMeshAgent agent;

    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        
        agent.SetDestination(GetRandomPosition());
    }

    
    void Update()
    {
        if (agent.velocity.magnitude > 0)
        {
            animator.SetBool("WL_Walk", true);
        }
        else
        {
            animator.SetBool("WL_Walk", false);
            agent.SetDestination(GetRandomPosition());
        }
    }

    private Vector3 GetRandomPosition()
    {
        Vector3 randomDirection = Random.insideUnitSphere * 10;
        randomDirection += transform.position;
        NavMeshHit hit;
        NavMesh.SamplePosition(randomDirection, out hit, 10, NavMesh.AllAreas);
        return hit.position;
    }
}

