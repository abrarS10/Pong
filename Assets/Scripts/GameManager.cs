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
    [SerializeField] int winningScore = 3;
    [SerializeField] GameObject endgame;
    [SerializeField] GameObject scoreboard;
    [SerializeField] GameObject pause;

    public Text title;


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
        if (playerScore == winningScore || computerScore == winningScore){
            endGame();
        }
    }

    private void endGame(){
        Time.timeScale = 0f;
        pause.GetComponent<Pause>().enabled = false;
        scoreboard.SetActive(false);
        if(playerScore == winningScore){
            title.text = "YOU WON!";
        } else if (computerScore == winningScore){
            title.text = "GAME OVER";
        }
        endgame.SetActive(true);
    }

    public void resetGame(){
        endgame.SetActive(false);
        pause.GetComponent<Pause>().enabled = true;
        scoreboard.SetActive(true);
        Time.timeScale = 1f;
        playerScore = 0;
        computerScore = 0;
        resetRound();
    }

    private void setScore(){
        this.playerScoreText.text = playerScore.ToString();
        this.computerScoreText.text = computerScore.ToString();
    }
    
}
