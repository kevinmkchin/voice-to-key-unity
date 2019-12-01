using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject obstacle;
    private int counter;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter >= 180) {

            System.Random random = new System.Random();
            int x = random.Next(-1, 2);
            int y = random.Next(-1, 2);

            Instantiate(obstacle, new Vector3(x, y, 2), Quaternion.identity);

            x = random.Next(-1, 2);
            y = random.Next(-1, 2);

            Instantiate(obstacle, new Vector3(x, y, 2), Quaternion.identity);

            x = random.Next(-1, 2);
            y = random.Next(-1, 2);
            Instantiate(obstacle, new Vector3(x, y, 2), Quaternion.identity);

            Debug.Log("spawn obstacles");
            counter = 0; //reset counter to 0
        }

        counter += 1;
    }
}
