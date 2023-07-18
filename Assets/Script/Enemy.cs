using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private AudioClip destroySound;
    [SerializeField] private int amount;
    [SerializeField] private Score points;
    [SerializeField] private Collider enemyCollider;

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
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
