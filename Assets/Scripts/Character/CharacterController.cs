namespace Character
{
    public class CharacterController : CharacterAnimator
    {
        // Update is called once per frame
        private void Update()
        {
            SetAnimation();
        }

        private void FixedUpdate()
        {
            Movement();
        }
    }
}
