using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public float speed = 200.0f;

    private void Awake(){
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Start(){
        ResetPosition();
        AddStartingForce();
    }

    public void AddStartingForce(){
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        Vector2 startDirection = new Vector2(x, y);
        rigidBody.AddForce(startDirection * this.speed);
    }

    public void AddForce(Vector2 force){
        rigidBody.AddForce(force);
    }

    public void ResetPosition(){
        rigidBody.position = Vector3.zero;
        rigidBody.velocity = Vector3.zero;
    }
}
