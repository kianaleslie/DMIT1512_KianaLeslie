using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateScript : MonoBehaviour
{
    GameState gameState;
    private void Start()
    {
        gameState = GameObject.FindGameObjectWithTag("GameState").GetComponent<GameState>();
    }
}