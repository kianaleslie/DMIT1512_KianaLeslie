using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data 
{
    public static int level = 0;
    public static int playerLives = 3;
    public static int playerScore = 0;
    public static int invaders = 0;

    public const int levelOneInvaders = 0;
    //48 level 1 invaders - 3 boss invaders
    public const int levelTwoInvaders = 51;
    public const int startLives = 3;

    public static string invadersText = "Enemies: ";
    public static string livesText = "Lives: ";
    public static string gameOverText = "Game Over";
    public static string playAgainText = "Play Again";
    public static string loseText = "YOU LOSE!";
    public static string winText = "YOU WIN!";
    public static string highScoreText = "High Score: ";
}