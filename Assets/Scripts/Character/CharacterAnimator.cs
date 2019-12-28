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
        if (Input.GetAxis("Vertical") > 0)
        {
            animator.ResetTrigger("Stay");

            if (Input.GetButton("Horizontal"))
                animator.Play("Run Up-Horizontal");
            else
                animator.Play("Run Up");
        }
        else
        if (Input.GetAxis("Vertical") < 0)
        {
            animator.ResetTrigger("Stay");

            if (Input.GetButton("Horizontal"))
                animator.Play("Run Down-Horizontal");
            else
                animator.Play("Run Down");
        }
        else
        if (Input.GetButton("Horizontal"))
        {
            animator.ResetTrigger("Stay");
            animator.Play("Run Horizontal");
        }
        else
            animator.SetTrigger("Stay");

        if (Input.GetButton("Horizontal"))
            spriteRenderer.flipX = Input.GetAxis("Horizontal") < 0;
    }
}
