using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectables : MonoBehaviour
{
    private int coins = 0;
    [SerializeField] private TextMeshProUGUI coinText;
    private int gems = 0;
    //[SerializeField] private TextMeshProUGUI gemText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            Destroy(collision.gameObject);
            coins++;
            coinText.text = "Coins: " + coins;
        }
        if (collision.gameObject.CompareTag("Gem"))
        {
            Destroy(collision.gameObject);
            gems++;
            //gemText.text = "Gems: " + gems;
            if (gems == 11)
            {
                GameSceneManager.LoadLevelTwo();
            }
        }
    }
}