using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Add fields for to handle game object and player control.
    public float horizontalInput;
    public float speed = 10.0f;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        // Get the input type for horizontal movement.
        horizontalInput = Input.GetAxis("Horizontal");
        
        // Move player right or left key arrow pressed.
        transform.Translate(Vector3.right * (horizontalInput * Time.deltaTime * speed));
        
        // Make boundaries for the player area.
        
        // spawn random objects.
    }
}