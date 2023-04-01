using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    private int coins = 0;
    [SerializeField] private TextMeshProUGUI coinText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            Destroy(collision.gameObject);
            coins++;
            coinText.text = "Coins: " + coins;
        }
    }
}