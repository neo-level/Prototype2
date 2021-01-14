﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 20.0f;
    private float spawnPositionZ = 20.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    private void Start()
    {
        // Spawn random animal on a time interval. Using an invoked method.
        InvokeRepeating(methodName: nameof(SpawnRandomAnimal), time: startDelay, repeatRate: spawnInterval);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            // Call method to generate an animal on a random location.
            SpawnRandomAnimal();
        }
    }

    private void SpawnRandomAnimal()
    {
        // Random store an index from the array to the variable. 
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // Random generate the spawn position of the animals.
        Vector3 spawnPosition = new Vector3(x: Random.Range(-spawnRangeX, spawnRangeX), y: 0, z: spawnPositionZ);

        // Instantiate a prefab.
        Instantiate(animalPrefabs[animalIndex], position: spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}