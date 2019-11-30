using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject obstacle;
    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        if (counter >= 120) {

            Instantiate(obstacle, new Vector3(1, 1, 1), Quaternion.identity);

            Debug.Log("spawn obstacles");
            counter = 0; //reset counter to 0
        }


        counter += 1;
    }
}
