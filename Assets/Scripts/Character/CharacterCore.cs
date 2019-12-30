using UnityEngine;

public class CharacterCore : MonoBehaviour
{
    protected Rigidbody2D rigidBody;

    public float speed = 5.0f;

    protected virtual void OnEnable()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
}
