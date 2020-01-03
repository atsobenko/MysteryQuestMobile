using UnityEngine;

public class Blackout : MonoBehaviour
{
    private Animator animator;

    private bool _isFadeIn, _isFadeOut = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public bool IsFadeIn()
    {
        return _isFadeIn;
    }

    public bool IsFadeOut()
    {
        return _isFadeOut;
    }

    public void Reload()
    {
        _isFadeIn = false;
        _isFadeOut = false;
    }

    public void FadeInEnd()
    {
        _isFadeIn = false;
    }

    public void FadeOutEnd()
    {
        _isFadeOut = false;
    }

    public void ForceFadeIn()
    {
        animator.Play("FadeIn");
        _isFadeIn = true;
    }

    public void ForceFadeOut()
    {
        animator.SetTrigger("FadeOut");
        _isFadeOut = true;
    }
}
