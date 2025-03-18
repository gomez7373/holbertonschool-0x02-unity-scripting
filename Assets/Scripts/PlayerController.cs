using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Speed variable to adjust movement speed in Inspector

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get the Rigidbody component attached to the Player
    }

    void FixedUpdate()
    {
        // Get input from WASD or Arrow Keys
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Create movement vector (X and Z axes only, no Y-axis movement)
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Apply movement force
        rb.AddForce(movement * speed);
    }
}
