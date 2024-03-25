using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private CoinsManager coinsManager;

    private void Awake()
    {
        coinsManager = Object.FindFirstObjectByType<CoinsManager>();
    }
    public void NextScene()
    {
        coinsManager.SaveCoinCount();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PreviousScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
