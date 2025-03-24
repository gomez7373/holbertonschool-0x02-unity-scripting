using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int score = 0;
    public int health = 5; // 🟥 Agregado para Task 6

    public float speed = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            score++;
            Debug.Log("Score: " + score);
            other.gameObject.SetActive(false);
        }

        if (other.CompareTag("Trap")) // 🔥 Task 6
        {
            health--;
            Debug.Log("Health: " + health);
        }

        if (other.CompareTag("Goal")) // ✅ Task 8
        {
            Debug.Log("You win!");
        }
    }
}
