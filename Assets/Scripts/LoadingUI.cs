using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingUI : MonoBehaviour
{
    public Slider slider;
    float loadingSpeed = 1f;

    private void Start()
    {
        slider.value = 0f;
    }

    private void Update()
    {
        slider.value += loadingSpeed * Time.deltaTime;

        if (slider.value >= 1f)
        {
            StartingLevel();
        }
    }

    private void StartingLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
