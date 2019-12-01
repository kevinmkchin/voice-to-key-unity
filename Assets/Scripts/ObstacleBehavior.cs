using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehavior : MonoBehaviour
{
    private bool incremented;
    private int speedMult;

    // Start is called before the first frame update
    void Start()
    {
        incremented = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * 1);

    }
}
