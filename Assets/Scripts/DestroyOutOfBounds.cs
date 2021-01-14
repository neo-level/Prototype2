using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBoundary = 30.0f;
    private float lowerBoundary = -10.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // Check if the object crosses the boundary.
        if (transform.position.z > topBoundary)
        {
            // Destroy object if the object passes the top boundary.
            Destroy(gameObject);

        } else if (transform.position.z < lowerBoundary)
        {
            // Destroy object if the object passes the down boundary.
            Destroy(gameObject);

        }
    }
}
