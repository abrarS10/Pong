using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 direction;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
            direction = Vector2.up;
        } else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
            direction = Vector2.down;
        } else {
            direction = Vector2.zero;
        }
    }

    //called at a fixed time interval, used for physics
    private void FixedUpdate() {
        if (direction.sqrMagnitude != 0){
            rigidBody.AddForce(direction * speed);
        }
    }
}
