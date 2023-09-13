using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] private AudioClip pointSound;
    [SerializeField] private int amountPoints;
    [SerializeField] private Score point;
    [SerializeField] private ParticleSystem boom;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            point.AddPoints(amountPoints);
            SoundsControl.Instance.Playsound(pointSound);
            Instantiate(boom, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}


