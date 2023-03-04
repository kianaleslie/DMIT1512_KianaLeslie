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
    public static string text;
    public static GameManager instance;
    [SerializeField] TextMeshProUGUI invadersText;
    public static int enemiesAlive = 50;

    public static int lives = 0;
    public static int highScore;

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
        text = $"You {winOrLose}!" + $"{Data.highScoreText}" + Data.playerScore;
    }
    //private void Awake()
    //{
    //    if (instance == null)
    //    {
    //        instance = this;
    //    }
    //}
    //public void TrackInvadersKilled()
    //{
    //    if (enemiesAlive > Data.levelOneInvaders && lives <= Data.playerLives)
    //    {
    //        enemiesAlive--;
    //        if (enemiesAlive == Data.levelOneInvaders && lives <= Data.playerLives)
    //        {
    //            LoadLevelTwo();
    //        }
    //        //if (lives == 0)
    //        //{
    //        //    LoadGameOver();
    //        //}
    //    }
    //    invadersText.text = enemiesAlive.ToString($"Enemies: {enemiesAlive}");
    //}
    //public void UpdateInvadersKilled()
    //{
    //    invadersText.text = "Enemies: " + enemiesAlive;
    //}
    //void Start()
    //{
    //    invadersText = GetComponent<TextMeshProUGUI>();
    //    //UpdateInvadersKilled();
    //    //invadersText.text = $"Enemies: {enemiesAlive}";  
    //}
    //void Update()
    //{
    //    // invadersText.text = $"Enemies: {enemiesAlive}";
    //    //TrackInvadersKilled();
    //}
}