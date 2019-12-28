using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : CharacterAnimator
{

    private Vector2 moveDirection = Vector2.zero;

    protected void Movement()
    {
        float horizontalAxis = Input.GetAxis("Horizontal") != 0 && Input.GetButton("Horizontal") ? Input.GetAxis("Horizontal") / Mathf.Abs(Input.GetAxis("Horizontal")) : 0;
        float verticalAxis = Input.GetAxis("Vertical") != 0 && Input.GetButton("Vertical") ? Input.GetAxis("Vertical") / Mathf.Abs(Input.GetAxis("Vertical")) : 0;

        moveDirection = new Vector2(horizontalAxis, verticalAxis) * speed;

        rigidBody.velocity = moveDirection * Time.deltaTime;
    }
}
