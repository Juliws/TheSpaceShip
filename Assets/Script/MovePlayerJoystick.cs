using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayerJoystick : MonoBehaviour
{
    [Header("Game Objects")]
    [SerializeField] public Joystick joystickmovement;
    [SerializeField] public GameObject Player;
    [SerializeField] public GameObject shoot;
    [SerializeField] private Rigidbody rb;

    [Header("Check Attributes")]
    [SerializeField] public float speed = 1f;
    [SerializeField] private Vector3 direction;

    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    void Update()
    {
        MovePlayer();
        Movimiento();
        FireShoot();
    }

    void MovePlayer()
    {
        float x = joystickmovement.Horizontal + Input.GetAxis("Horizontal");
        float z = joystickmovement.Vertical + Input.GetAxis("Vertical");

        Vector3 direccionX = x * Vector3.right;
        Vector3 direccionZ = z * Vector3.forward;

        Vector3 direccion = direccionX + direccionZ;
        Vector3 vectorSpeed = direccion * speed;

        rb.velocity = vectorSpeed;
    }

    public void Movimiento()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void FireShoot()
    {
        bool shooting = SimpleInput.GetButtonDown("Jump");
        
        if (shooting)
        {
            Instantiate(shoot, transform.position, shoot.transform.rotation);
        }
    }
}
