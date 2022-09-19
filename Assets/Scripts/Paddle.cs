using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    protected Rigidbody2D rigidBody;
    public float speed = 10.0f;

    private void Awake(){
        rigidBody = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition(){
        rigidBody.position = new Vector2(rigidBody.position.x, 0.0f);
        rigidBody.velocity = Vector2.zero;
    }

    
}
