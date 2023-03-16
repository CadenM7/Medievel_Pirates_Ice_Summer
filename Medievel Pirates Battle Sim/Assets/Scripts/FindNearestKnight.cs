using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// Adapted From https://www.youtube.com/watch?v=BjpZdOwZIT4
public class SampleNearestObject : MonoBehaviour
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
        print("We are updating");
        nearestDistance = 1000000;
        AllEnemies = GameObject.FindGameObjectsWithTag("Knight");
        for (int i = 0; i < AllEnemies.Length; i++) {
            distance = Vector3.Distance(this.transform.position, AllEnemies[i].transform.position);
            if (distance < nearestDistance) {
                print("We got a new target!");
                NearestEnemy = AllEnemies[i];
                nearestDistance = distance;
            }
        }
        print("We finding nearest Pirate");
        navigation.destination = NearestEnemy.transform.position;
    }
}
