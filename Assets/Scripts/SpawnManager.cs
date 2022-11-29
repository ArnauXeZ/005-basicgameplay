using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    private float spawnRangeX = 15;
    private float spawnPosZ = 20;
    public float startDelay = 2f;
    public float spawnInterval = 1.5f;


    private Vector3 RandomSpawnPos()
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        return new Vector3(randomX, 0, spawnPosZ);
    }

    private void SpawnRandomAnimal()
    {
        animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], RandomSpawnPos(), Quaternion.identity);
    }

    private void Start()
    {
       InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

}

