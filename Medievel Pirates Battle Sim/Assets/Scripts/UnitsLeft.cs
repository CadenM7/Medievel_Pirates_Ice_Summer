using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UnitsLeft : MonoBehaviour
{
    public static UnitsLeft instance {get; private set;}
    public TextMeshProUGUI scoreText;

    int knights_left = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Knights Left: " + knights_left.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        knights_left = GameObject.FindGameObjectsWithTag("Knight").Length;
        scoreText.text = "Knights Left: " + knights_left.ToString();
    }
}
