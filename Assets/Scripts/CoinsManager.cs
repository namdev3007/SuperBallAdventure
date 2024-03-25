using UnityEngine;

public class CoinsManager : MonoBehaviour
{
    public int coinCount = 0;

    void Start()
    {
        coinCount = PlayerPrefs.GetInt("coinCount", 0);
    }

    public void SaveCoinCount()
    {
        PlayerPrefs.SetInt("coinCount", coinCount);
        PlayerPrefs.Save();
    }
}
