using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UITextLevel2 : MonoBehaviour
{
    [SerializeField] GameObject[] invaders;
    public static float playerScore = 0;
    //public TextMeshProUGUI scoreText;
    public TextMeshProUGUI enemyText;
    void Start()
    {
        //enemyText = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        invaders = GameObject.FindGameObjectsWithTag("Invaders");
        enemyText.text = "Enemies: " + invaders.Length.ToString();
        if (invaders.Length == 0)
        {
            GameManager.LoadGameOver();
        }
    }
}
