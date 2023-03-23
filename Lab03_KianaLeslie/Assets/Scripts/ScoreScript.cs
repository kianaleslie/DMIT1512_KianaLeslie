using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] GameObject score1;
    [SerializeField] GameObject score2;
    [SerializeField] GameObject score3;
    [SerializeField] GameObject ball;
    protected GameState gameState;
     GameStateManager gameStateManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Score1")
        {
            gameState.score += 20;

        }
        if (collision.gameObject.tag == "Score2")
        {
            gameState.score += 50;
        }
        if (collision.gameObject.tag == "Score3")
        {
            gameState.score += 5;
        }
        if (collision.gameObject.tag == "DeathZone")
        {
            gameState.lives -= 1;
            if(gameState.lives == 0)
            {
                gameStateManager.SaveToDisk();
                GameSceneManager.LoadGameOver();
            }
        }
    }
    void Start()
    {
        gameState = GameObject.FindObjectOfType<GameState>();
        gameStateManager = GameObject.FindObjectOfType<GameStateManager>();
    }
    private void Update()
    {
        if (gameState.score > gameState.highScore)
        {
            gameState.highScore = gameState.score;
        }
    }
}