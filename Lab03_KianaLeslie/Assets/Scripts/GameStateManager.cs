using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI highscoreText;
    [SerializeField] TextMeshProUGUI livesText;
    protected GameState gameState;
    string path;
    private void Awake()
    {
        path = Path.Combine(Application.persistentDataPath, "Pinball_Highscore.txt");
    }
    private void Start()
    {
        gameState = GameObject.FindObjectOfType<GameState>();  
        LoadFromDisk();
    }
    public void LoadFromDisk()
    {
        if(File.Exists(path))
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string jsonString = sr.ReadToEnd();
                JsonUtility.FromJsonOverwrite(jsonString, gameState);
                gameState.lives = 3;
                gameState.score = 0;
            }
        }
    }
    public void SaveToDisk()
    {
        string jsonString = JsonUtility.ToJson(gameState);
        using (StreamWriter sw = File.CreateText(path))
        {
            sw.Write(jsonString);
        }
    }
    private void Update()
    {
        scoreText.text = $"Score: {gameState.score}";
        highscoreText.text = $"Highscore: {gameState.highScore}";
        livesText.text = $"Live(s): {gameState.lives}";
    }
}