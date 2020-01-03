using UnityEngine;

namespace Character
{
    public class CharacterAnimator : CharacterMovement
    {
        private Animator _animator;
        private SpriteRenderer _spriteRenderer;
        private static readonly int Horizontal = Animator.StringToHash("Horizontal");
        private static readonly int Vertical = Animator.StringToHash("Vertical");
        private static readonly int Speed = Animator.StringToHash("Speed");

        protected virtual void Awake()
        {
            _animator = GetComponent<Animator>();
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        protected void SetAnimation()
        {
            _animator.SetFloat(Horizontal, MoveDirection.x);
            _animator.SetFloat(Vertical, MoveDirection.y);
            _animator.SetFloat(Speed, MoveDirection.sqrMagnitude);

            if (Input.GetButton("Horizontal") && movementAbility)
            {
                _spriteRenderer.flipX = Input.GetAxis("Horizontal") < 0;
            }
        }
    }
}
