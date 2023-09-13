using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 54.5f;
    private float lowerBound = -54.5f;

    void Update()
    {
        //Limit Up
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        //Limit Down
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
