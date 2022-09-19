using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadGame(){
        Debug.Log("start again");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void LoadMenu(){
        SceneManager.LoadScene(1);
    }

    public void QuitGame(){
        Application.Quit();
        Debug.Log("Quit");
    }
}
