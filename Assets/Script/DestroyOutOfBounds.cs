using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 45.2f;
    private float lowerBound = -35.5f;

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
            Debug.Log("Extinto");
            Destroy(gameObject);
        }
    }
}
