using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Text = TMPro.TMP_Text;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public static bool playGame = true;
    public static int highScore;
    public static string text;

    public static void LoadLevelTwo()
    {
        GameSceneManager.LoadLevelTwo();
    }
    public static void LoadMainMenu()
    {
        GameSceneManager.LoadMainMenu();
    }
    public static void LoadGameOver()
    {
        GameSceneManager.LoadGameOver();
    }
    public static void WinOrLose(string winOrLose)
    {
        text = $"You {winOrLose}!" + $"High Score: " + Data.playerScore;
    }
}