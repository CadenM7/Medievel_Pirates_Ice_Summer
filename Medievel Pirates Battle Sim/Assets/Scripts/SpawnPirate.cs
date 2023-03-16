using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPirate : MonoBehaviour
{

    public GameObject pirate;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                // Check if it is within the transform area to add unit
                Instantiate(pirate, hit.point, Quaternion.identity);
                print("Object Should be clicked by mouse");
            }
        }
    }

}
