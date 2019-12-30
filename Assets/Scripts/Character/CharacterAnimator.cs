using UnityEngine;

public class CharacterAnimator : CharacterMovement
{
    Animator animator;
    SpriteRenderer spriteRenderer;

    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    protected void SetAnimation()
    {
        animator.SetFloat("Horizontal", moveDirection.x);
        animator.SetFloat("Vertical", moveDirection.y);
        animator.SetFloat("Speed", moveDirection.sqrMagnitude);

        if (Input.GetButton("Horizontal"))
            spriteRenderer.flipX = Input.GetAxis("Horizontal") < 0;
    }
}
