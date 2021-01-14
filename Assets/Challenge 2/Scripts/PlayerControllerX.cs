using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    
    // Time placeholder.
    public float spawnRate = 1.0f;
    public float timestamp = 0.0f;
    
    // Update is called once per frame
    void Update()
    {
        // On space bar press, send dog. but prevent spam.
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= timestamp)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timestamp = Time.time + spawnRate;
        }
    }
}
