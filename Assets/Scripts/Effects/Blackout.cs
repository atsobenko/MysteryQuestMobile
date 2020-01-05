using UnityEngine;

namespace Effects
{
    public class Blackout : MonoBehaviour
    {
        private Animator _animator;

        private bool _isFadeIn, _isFadeOut;
        private static readonly int FadeOut = Animator.StringToHash("FadeOut");

        // Start is called before the first frame update
        void Start()
        {
            _animator = GetComponent<Animator>();
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
            gameObject.SetActive(false);
        }

        public void ForceFadeIn()
        {
            gameObject.SetActive(true);
            _animator.Play("FadeIn");
            _isFadeIn = true;
        }

        public void ForceFadeOut()
        {
            _animator.SetTrigger(FadeOut);
            _isFadeOut = true;
        }
    }
}
