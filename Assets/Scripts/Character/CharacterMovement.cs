using UnityEngine;

namespace Character
{
    public class CharacterMovement : CharacterCore
    {

        protected Vector2 MoveDirection = Vector2.zero;

        protected void Movement()
        {
            var horizontalAxis = Input.GetAxis("Horizontal");
            var verticalAxis = Input.GetAxis("Vertical");
        
            MoveDirection.x = Input.GetButton("Horizontal") ? horizontalAxis / Mathf.Abs(horizontalAxis) : 0;
            MoveDirection.y = Input.GetButton("Vertical") ? verticalAxis / Mathf.Abs(verticalAxis) : 0;

            RigidBody.MovePosition(RigidBody.position + MoveDirection * (speed * Time.fixedDeltaTime));
        }
    }
}
