using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Adapted from https://github.com/llamacademy/worldspace-health-bars/blob/main/Assets/Scripts/Enemy.cs
public class Unit : MonoBehaviour, IDamageable
{
    [SerializeField]
    private int Health = 100;

    private UnityEngine.AI.NavMeshAgent Agent;
    private float MaxHealth;

    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = Health;
        Agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // From Unity Documentation
    void OnCollisionEnter(Collision collision)
    {
        print("We collided");
        print(collision.gameObject.tag);
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Pirate")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            print("That filthy Pirate");
            print("Darn");
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

    }
}
