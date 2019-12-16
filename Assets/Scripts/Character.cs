using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    Rigidbody2D rigidBody;

    public float speed = 30.0f;

    private Vector2 moveDirection = Vector2.zero;

    void Start()
    {
        speed *= 100;
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
 
            // We are grounded, so recalculate
            // move direction directly from axes

            moveDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            moveDirection *= speed;

     

        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
   

        // Move the controller
        rigidBody.velocity = moveDirection * Time.deltaTime;
    }
}
