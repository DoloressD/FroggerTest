using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    public GameObject go;

    public Transform[] spawnPoints;

    public float spawnDelay = 0.3f;
    private float timeToSpawn = 0f;

    void Update()
    {
        if (timeToSpawn <= Time.time)
        {
            SpawnCar();
            timeToSpawn = Time.time + spawnDelay;
        }
    }

    void SpawnCar()
    {
        int randIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randIndex];

        Instantiate(go, spawnPoint.position, spawnPoint.rotation);
    }
}
