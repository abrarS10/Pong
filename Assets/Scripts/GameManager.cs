using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public Text playerScoreText;
    public Text computerScoreText;
    private int playerScore;
    private int computerScore;

    public void PlayerScores(){
        playerScore++;
        this.resetRound();
    }

    public void ComputerScores(){
        computerScore++;
        this.resetRound();
    }

    private void resetRound(){
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        setScore();
    }

    private void Update(){
        if (playerScore == 3 || computerScore == 3){
            resetGame();
        }
    }

    private void resetGame(){
        playerScore = 0;
        computerScore = 0;
        resetRound();
    }

    private void setScore(){
        this.playerScoreText.text = playerScore.ToString();
        this.computerScoreText.text = computerScore.ToString();
    }
    
}
