using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPersonaje : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private Vector3 direccion;
    [SerializeField] private GameObject shoot;
    [SerializeField] private float xRange=41.0f,zRange=26.0f;

    void Update()
    {
        MovePlayer();
        PresionarBotones();
        Fire();
    }

    public void MovePlayer()
    {
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }

    public void PresionarBotones()
    {
        direccion = Vector2.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            direccion += Vector3.forward;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            direccion += Vector3.back;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direccion += Vector3.left;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            direccion += Vector3.right;
        }
    }

    public void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shoot, transform.position, shoot.transform.rotation);
        }
    }

    public void limits()
    {
        // Condition space limit left to player
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        // Condition space limit rigth to player
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Condition space limit up to player
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        // Condition space limit down to player
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
    }
}
