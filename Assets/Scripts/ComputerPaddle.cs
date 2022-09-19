using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;

    private void FixedUpdate() {
        //if ball is moving towards the CPU
        if (this.ball.velocity.x > 0.0f){
            if (this.ball.position.y > this.transform.position.y) {
                rigidBody.AddForce(Vector2.up * speed);
            } else if (this.ball.position.y < this.transform.position.y){
                rigidBody.AddForce(Vector2.down * speed);
            }
        } else { //if ball is moving away from the CPU
            if (this.transform.position.y > 0.0f){
                rigidBody.AddForce(Vector2.down * speed);
            } else if (this.transform.position.y < 0.0f){
                rigidBody.AddForce(Vector2.up * speed);
            }
        }
    }

}
