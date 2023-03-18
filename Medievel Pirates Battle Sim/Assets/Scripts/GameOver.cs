using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public GameObject[] AllEnemies;
    public GameObject NearestEnemy;
    float distance;
    //float nearestDistance = 1000000;

    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AllEnemies = GameObject.FindGameObjectsWithTag("Knight");
        if (AllEnemies.Length == 0) {
            gameOver = true;
        }
    }
}
