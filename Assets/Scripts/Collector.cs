using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Collector : MonoBehaviour
{
    private CoinsManager coinsManager;
    private SceneController controller;
    private HealthManager healthManager;


    private void Awake()
    {
        coinsManager = Object.FindFirstObjectByType<CoinsManager>();
        controller = Object.FindFirstObjectByType<SceneController>();
        healthManager = Object.FindFirstObjectByType<HealthManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Coin"))
        {
            coinsManager.coinCount += 50;
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.CompareTag("Gate"))
        {
            Invoke("LoadNextScene", 1f);
        }

        if(collision.gameObject.CompareTag("Enemy"))
        {
            healthManager.health--;

        }    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            coinsManager.coinCount += 100;
            StartCoroutine(DestroyAfterDelay(collision.gameObject, 0.3f));
        }
    }

    IEnumerator DestroyAfterDelay(GameObject obj, float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(obj);
    }
    void LoadNextScene()
    {
        controller.NextScene();
    }
}
