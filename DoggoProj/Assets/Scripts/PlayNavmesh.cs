using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayNavmesh : MonoBehaviour
{

    public float speed = 3.5f;
    public float rotationSpeed = 120.0f;
    public float jumpPower = 5.0f;
    public Animator animator;
    [SerializeField] private Transform movePositionTransform;
    private NavMeshAgent navMeshAgent;
    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        navMeshAgent.destination = movePositionTransform.position;
    }

    private void Update()
    {
        navMeshAgent.destination = movePositionTransform.position;

        if (navMeshAgent.velocity.magnitude > 0)
        {
            animator.SetBool("Locomotion", true);
        }
        else
        {
            animator.SetBool("Locomotion", false);
        
        }
    }
}
