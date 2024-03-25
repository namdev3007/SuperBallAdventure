using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HomeUI : MonoBehaviour
{
    private CoinsManager coinsManager;

    public TextMeshProUGUI coinsText;
    public TextMeshProUGUI livesText;

    private void Awake()
    {
        coinsManager = Object.FindFirstObjectByType<CoinsManager>();
    }

    private void Update()
    {
        UpdateCoins();
    }

    private void UpdateCoins()
    {
        coinsText.text = coinsManager.coinCount.ToString();
    }
}
