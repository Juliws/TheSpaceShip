using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardBullet : MonoBehaviour
{
    public float speed = 10;

    //Food shooting moving forward
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
