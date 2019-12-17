using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : CharacterAnimator
{

    private Vector2 moveDirection = Vector2.zero;

    protected void Movement()
    {
        moveDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveDirection *= speed;

        rigidBody.velocity = moveDirection * Time.deltaTime;
    }
}
