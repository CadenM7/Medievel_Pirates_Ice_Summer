using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemyfollow : MonoBehaviour
{

    public Transform goal;
    private NavMeshAgent agent;
    private Animator animator;
    private Vector3 velocity;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = goal.position;
        velocity = agent.velocity;
        animator.SetFloat("velocity", velocity.magnitude);
    }
}
