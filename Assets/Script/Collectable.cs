using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] private AudioClip pointSound;
    [SerializeField] private int amountPoints;
    [SerializeField] private Score points;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            points.AddPoints(amountPoints);
            SoundsControl.Instance.Playsound(pointSound);
            Destroy(gameObject);
        }
    }
}


