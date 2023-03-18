using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Unpause : MonoBehaviour
{
    public GameObject text;
    public GameObject button;
    public GameObject[] AllKnights;
    public GameObject[] AllPirates;
    public GameObject PirateSpace;
    public GameObject camera2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UnPause()
    {
        print("test");
        AllKnights = GameObject.FindGameObjectsWithTag("Knight");
        for (int i = 0; i < AllKnights.Length; i++) {
            AllKnights[i].GetComponent<FindNearestPirate>().turnOn();
        }
        AllPirates = GameObject.FindGameObjectsWithTag("Pirate");
        for (int i = 0; i < AllPirates.Length; i++) {
            AllPirates[i].GetComponent<FindNearestKnight>().turnOn();
        }
        PirateSpace.GetComponent<FindNearestKnight>().turnOn();
        camera2.GetComponent<FPSCamera>().turnOn();
        text.SetActive(true);
        button.SetActive(false);
    }
}
