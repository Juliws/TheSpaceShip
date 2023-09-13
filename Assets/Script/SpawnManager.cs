using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] objects;
    private float spawnRangeX = 70;
    private float spawnPosZ = 54.4f;
    private float startDelay = 1.5f;
    private float spawnInterval = 1.0f;
    public float sideSpawnMinZ = 2.0f;
    public float sideSpawnMaxZ = 14.0f;
    public float sideSpawnX = 54.4f;

    void Start()
    {
        //Random creation of animals
        InvokeRepeating("SpawnRandomObjects", startDelay, spawnInterval);
    }

    void Update()
    {

    }
    void SpawnRandomObjects()
    {
        // X Randomly generate animal index and spawn position
        int objectsIndex = Random.Range(0, objects.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(objects[objectsIndex], spawnpos, objects[objectsIndex].transform.rotation);
    }
       
}

