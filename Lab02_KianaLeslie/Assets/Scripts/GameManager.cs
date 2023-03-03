using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Text = TMPro.TMP_Text;

public class GameManager : MonoBehaviour
{
    public static bool playGame = true;
    //public PlayerShip player;

    public Text scoreText;
    public Text livesText;

    public int Score { get; private set; }
    public int Lives { get; private set; }

    public static void LoadLevelTwo()
    {
        GameSceneManager.LoadLevelTwo();
    }
    public static void LoadMainMenu()
    {
        GameSceneManager.LoadMainMenu();
    }
    //public static void GameOver()
    //{
    //    GameManager.LoadMainMenu();
    //}
    public void SetScore(int score)
    {
        Score = score;
        scoreText.text = score.ToString("0");
    }

    public void SetLives(int lives)
    {
        Lives = Mathf.Max(lives, 0);
        livesText.text = lives.ToString();
    }
    public void PlayerKilled()
    {
        SetLives(Lives - 1);
        if (Lives > 0)
        {
            Respawn();
        }
        else
        {
            //GameOver();
        }

    }
    public Vector3 Respawn()
    {
        playGame = false;
        Vector3 respawnPlayer = new Vector3(8, -4, 0);
        return respawnPlayer;
    }
    void Start()
    {

    }
    void Update()
    {

    }
}