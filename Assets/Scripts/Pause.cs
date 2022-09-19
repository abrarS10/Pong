using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    
    public static bool isPaused = false;
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject scores;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (isPaused){
                ResumeGame();
            } else {
                PauseGame();
            }
        }
    }

    public void ResumeGame(){
        pauseMenu.SetActive(false);
        scores.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void PauseGame(){
        pauseMenu.SetActive(true);
        scores.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
    }

}
