using UnityEditor.Animations;
using UnityEngine;

public class CharacterAnimator : CharacterCore
{
    Animator animator;
    SpriteRenderer spriteRenderer;

    enum states
    {
        leftRun,
        rightRun
    }

    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    protected void SetAnimation()
    {
        if (Input.GetButton("Horizontal"))
            animator.Play("Run Horizontal");
        else if (Input.GetAxis("Vertical") > 0)
            animator.Play("Run Up");
        else if (Input.GetAxis("Vertical") < 0)
            animator.Play("Run Horizontal");
        else
            animator.Play("Idle");

        if (Input.GetAxis("Horizontal") < 0)
            spriteRenderer.flipX = true;
        else if (Input.GetAxis("Horizontal") > 0)
            spriteRenderer.flipX = false;
    }
}
