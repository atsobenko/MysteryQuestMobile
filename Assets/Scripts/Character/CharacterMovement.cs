using UnityEngine;

public class CharacterMovement : CharacterCore
{

    protected Vector2 moveDirection = Vector2.zero;

    protected void Movement()
    {
        moveDirection.x = Input.GetAxis("Horizontal") != 0 && Input.GetButton("Horizontal") ? Input.GetAxis("Horizontal") / Mathf.Abs(Input.GetAxis("Horizontal")) : 0;
        moveDirection.y = Input.GetAxis("Vertical") != 0 && Input.GetButton("Vertical") ? Input.GetAxis("Vertical") / Mathf.Abs(Input.GetAxis("Vertical")) : 0;

        rigidBody.MovePosition(rigidBody.position + moveDirection * speed * Time.fixedDeltaTime);
    }
}
