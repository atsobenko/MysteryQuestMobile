using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCore : MonoBehaviour
{
    protected Rigidbody2D rigidBody;

    public float speed = 5.0f;

    protected virtual void OnEnable()
    {
        speed *= 50f;
        rigidBody = GetComponent<Rigidbody2D>();
    }
}
