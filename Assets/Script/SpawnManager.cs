using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] objects;
    private float spawnRangeX = 42;
    private float spawnPosZ = 33;
    private float startDelay = 2;
    private float spawnInterval = 2.0f;
    public float sideSpawnMinZ = 2.0f;
    public float sideSpawnMaxZ = 14.0f;
    public float sideSpawnX = 20f;

    void Start()
    {
        //Random creation of animals
        InvokeRepeating("SpawnRandomAnimals", startDelay, spawnInterval);
    }

    void Update()
    {

    }
    void SpawnRandomAnimals()
    {
        // X Randomly generate animal index and spawn position
        int objectsIndex = Random.Range(0, objects.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(objects[objectsIndex], spawnpos, objects[objectsIndex].transform.rotation);
    }
       
}

