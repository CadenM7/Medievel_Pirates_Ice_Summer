using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKnight : MonoBehaviour
{

    public GameObject knight;


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
                if (hit.collider.tag == "Spawner") {
                    Instantiate(knight, hit.point, Quaternion.identity);
                    print("Object Should be clicked by mouse");
                }
                
            }
        }
    }

}
