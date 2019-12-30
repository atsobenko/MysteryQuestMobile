using UnityEngine;

namespace Character
{
    public class CharacterCore : MonoBehaviour
    {
        protected Rigidbody2D RigidBody;

        public float speed = 5.0f;

        protected virtual void OnEnable()
        {
            RigidBody = GetComponent<Rigidbody2D>();
        }
    }
}
