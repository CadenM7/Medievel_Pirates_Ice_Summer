using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Adapted from https://github.com/llamacademy/worldspace-health-bars/blob/main/Assets/Scripts/Enemy.cs
public class Pirate : MonoBehaviour, IDamageable
{
    [SerializeField]
    private int Health = 100;

    private UnityEngine.AI.NavMeshAgent Agent;
    private float MaxHealth;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = Health;
        Agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // From Unity Documentation
    void OnCollisionEnter(Collision collision)
    {
        print("We collided");
        if (collision.gameObject.tag == "Knight")
        {
            print("Arg.. That knight!");
            animator.SetTrigger("Collision");
            OnTakeDamage(45);
            Vector3 direction = (collision.transform.position - transform.position).normalized;
            Vector3 knockback = direction * 300f;
            GetComponent<Collider>().attachedRigidbody.AddForce(-knockback);

        }
    }

    public void OnTakeDamage(int Damage)
    {
        Health -= Damage;

        if (Health < 0)
        {
            OnDied();
            Agent.enabled = false;
        }
    }

    private void OnDied()
    {
        Destroy(gameObject, 1f);
    }

    // Update is called once per frame
    void Update()
    {


        Vector3 Adirection = (transform.position);

        transform.rotation = Quaternion.LookRotation(Adirection);
    }
}
