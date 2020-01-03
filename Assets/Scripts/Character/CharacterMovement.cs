using System;
using UnityEngine;

namespace Character
{
    public class CharacterMovement : CharacterCore
    {

        protected Vector2 MoveDirection = Vector2.zero;

        protected bool movementAbility = true;

        protected void Movement()
        {
            if (movementAbility)
            {
                var horizontalAxis = Input.GetAxis("Horizontal");
                var verticalAxis = Input.GetAxis("Vertical");

                MoveDirection.x = Math.Abs(horizontalAxis) > 0 && Input.GetButton("Horizontal") ? horizontalAxis / Mathf.Abs(horizontalAxis) : 0;
                MoveDirection.y = Math.Abs(verticalAxis) > 0 && Input.GetButton("Vertical") ? verticalAxis / Mathf.Abs(verticalAxis) : 0;

                RigidBody.MovePosition(RigidBody.position + MoveDirection * (speed * Time.fixedDeltaTime));
            }
            else
                MoveDirection = Vector2.zero;
        }

        public void ToggleMovementAbility()
        {
            movementAbility = !movementAbility;
        }
    }
}
