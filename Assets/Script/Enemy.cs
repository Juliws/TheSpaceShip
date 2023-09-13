using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private AudioClip destroySound;
    [SerializeField] private int amount;
    [SerializeField] private Score points;
    [SerializeField] private Collider enemyCollider;
    [SerializeField] private ParticleSystem boom;

    private void Start()
    {
        enemyCollider = GetComponentInChildren<Collider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shoot"))
        {
            points.AddPoints(amount);
            SoundsControl.Instance.Playsound(destroySound);
            Instantiate(boom, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
