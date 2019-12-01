using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    void OnTriggerEnter()
    {
        Debug.Log("collided");
        GameManager.died = true;
        transform.position = new Vector3(0,0,0);
    }

}
