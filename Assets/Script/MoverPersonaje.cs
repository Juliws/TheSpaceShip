using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPersonaje : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private Vector3 direccion;
    [SerializeField] private GameObject shoot;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float moveForce;
    [SerializeField] private float xRange = 74.0f, zRange = 38.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MovePlayer();
        PresionarBotones();
        Fire();
        //limits();
    }

    public void MovePlayer()
    {
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }

    public void PresionarBotones()
    {
        Vector3 direccionX = Input.GetAxis("Horizontal") * Vector3.right;
        Vector3 direccionZ = Input.GetAxis("Vertical") * Vector3.forward;

        Vector3 direccion = direccionX + direccionZ;
        Vector3 vectorSpeed = direccion * velocidad;

        rb.velocity = vectorSpeed;

        /*direccion = Vector2.zero;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.forward * moveForce, ForceMode.Impulse);
            //direccion += Vector3.forward;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.back * moveForce, ForceMode.Impulse);
            //direccion += Vector3.back;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * moveForce, ForceMode.Impulse);
            //direccion += Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * moveForce, ForceMode.Impulse);
            //direccion += Vector3.right;
        }*/

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
