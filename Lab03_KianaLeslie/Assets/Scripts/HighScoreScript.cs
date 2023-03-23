using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScoreScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI highscoreText;
    [SerializeField] TextMeshProUGUI currentScoreText;
    protected GameState gameState;
    void Start()
    {
        gameState = GameObject.FindObjectOfType<GameState>();
    }
    void Update()
    {
        currentScoreText.text = $"Your Score: {gameState.score}";
        if (gameState.score > gameState.highScore)
        {
            gameState.highScore = gameState.score;
        }
        highscoreText.text = $"Highscore: {gameState.highScore}";
    }
}