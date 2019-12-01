using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehavior : MonoBehaviour
{
    private int score;
    private bool incremented;
    private int speedMult;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        incremented = false;
        speedMult = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speedMult);
       
        float z = transform.position.z;

        if (z <= 0 && !incremented)
        {
            score++;
            incremented = true;
        }

    }
}
