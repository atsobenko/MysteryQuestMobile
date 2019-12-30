public class CharacterController : CharacterAnimator
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetAnimation();
    }

    void FixedUpdate()
    {
        Movement();
    }
}
