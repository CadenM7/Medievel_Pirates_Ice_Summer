using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// Adapted From https://www.youtube.com/watch?v=BjpZdOwZIT4
public class FindNearestPirate : MonoBehaviour
{

    public GameObject[] AllEnemies;
    public GameObject NearestEnemy;
    float distance;
    float nearestDistance = 1000000;

    public NavMeshAgent navigation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nearestDistance = 1000000;
        AllEnemies = GameObject.FindGameObjectsWithTag("Pirate");
        for (int i = 0; i < AllEnemies.Length; i++) {
            distance = Vector3.Distance(this.transform.position, AllEnemies[i].transform.position);
            if (distance < nearestDistance) {
                NearestEnemy = AllEnemies[i];
                nearestDistance = distance;
            }
        }
        navigation.destination = NearestEnemy.transform.position;
    }
}
