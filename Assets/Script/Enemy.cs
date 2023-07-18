using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private AudioClip destroySound;
    [SerializeField] private int amount;
    [SerializeField] private Score points;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Shoot")
        {
            points.AddPoints(amount);
            SoundsControl.Instance.Playsound(destroySound);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
