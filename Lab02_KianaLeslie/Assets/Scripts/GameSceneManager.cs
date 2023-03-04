using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public static void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public static void LoadLevelOne()
    {
        Data.level = 1;
        Data.playerLives = Data.startLives;
        Data.invaders = Data.levelOneInvaders;
        SceneManager.LoadScene(1);
    }
    public static void LoadLevelTwo()
    {
        Data.level = 2;
        Data.invaders = Data.levelTwoInvaders;
        SceneManager.LoadScene(2);
    }
    public static void LoadGameOver()
    {
        SceneManager.LoadScene(3);
    }
}