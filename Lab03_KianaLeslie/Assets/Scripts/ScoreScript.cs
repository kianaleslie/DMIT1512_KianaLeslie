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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Score1")
        {
            gameState.score += 5;
        }
        if (collision.gameObject.tag == "Score2")
        {
            gameState.score += 50;
        }
        if (collision.gameObject.tag == "Score3")
        {
            gameState.score += 20;
        }
    }
    void Start()
    {
        gameState = GameObject.FindObjectOfType<GameState>();
    }
}