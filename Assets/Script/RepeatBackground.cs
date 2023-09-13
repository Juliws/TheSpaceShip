using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    [SerializeField] private Vector3 startPos;
    [SerializeField] private float repeatWidth;
    
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.z/0.06f;
    }

    // Update is called once per frame
    void Update()
    {
        RepeatBackg();
    }

    void RepeatBackg()
    {
        if(transform.position.z < startPos.z - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
