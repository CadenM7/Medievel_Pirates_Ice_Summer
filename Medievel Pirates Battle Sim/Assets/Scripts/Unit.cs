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
