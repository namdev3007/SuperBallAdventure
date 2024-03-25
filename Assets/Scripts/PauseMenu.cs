using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private SceneController sceneController;
    public GameObject pausePanel;

    private void Awake()
    {
        sceneController = Object.FindFirstObjectByType<SceneController>();
    }

    public void Pause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Continue()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Reload()
    {
        pausePanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void BackHome()
    {
        sceneController.PreviousScene();
    }    

    public void GameOver()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
    }    
}
