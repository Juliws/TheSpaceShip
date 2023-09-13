using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipFollow : MonoBehaviour
{
    public Transform player;
    [SerializeField] private float move = 10f;
    [SerializeField] private float tiempo;
    [SerializeField] private GameObject spawn;
    [SerializeField] private GameObject bullet;

    // Update is called once per frame
    void Update()
    {
        Vector3 posJugador = new Vector3(player.position.x, transform.position.y, player.position.z);
        transform.LookAt(posJugador);
        transform.position = Vector3.MoveTowards(transform.position, posJugador, move * Time.deltaTime);

        ShootTime();
    }

        private void ShootTime()
        {
            tiempo = tiempo + Time.deltaTime;
            if(tiempo > 1f)
            {
            Instantiate(bullet.transform, spawn.transform.position, Quaternion.identity);
            tiempo = 0;
            }
        }
}
