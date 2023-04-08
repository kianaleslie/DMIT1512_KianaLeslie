
using UnityEngine;

public class SaveCoinCount : MonoBehaviour
{
    string coinKey = "Coins";
    public int CurrentCoinCount { get; set; }
    private void Awake()
    {
        CurrentCoinCount = PlayerPrefs.GetInt(coinKey);
    }
    public void SetCoinCount(int coins)
    {
        PlayerPrefs.SetInt(coinKey, coins);
    }
}