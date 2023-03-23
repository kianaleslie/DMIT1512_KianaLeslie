using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScoreScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI highscoreText;
    protected GameState gameState;
    void Start()
    {
        gameState = GameObject.FindObjectOfType<GameState>();
    }
    void Update()
    {
        gameState.highScore = gameState.score;
        highscoreText.text = $"Highscore: {gameState.highScore}";
    }
}