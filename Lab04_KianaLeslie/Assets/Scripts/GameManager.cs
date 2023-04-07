using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
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
}