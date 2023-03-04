using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UITextLevel2 : MonoBehaviour
{
    [SerializeField] GameObject[] invaders;

    [SerializeField] TMP_Text playerText;
    public TextMeshProUGUI invaderText;
    void Update()
    {
        invaders = GameObject.FindGameObjectsWithTag("Invaders");
        invaderText.text = "Enemies: " + invaders.Length.ToString();
        playerText.text = "Lives: " + Data.playerLives.ToString();
        if (invaders.Length == 0)
        {
            if (Data.playerLives > 0)
            {
                GameManager.LoadGameOver();
                GameManager.WinOrLose(Data.winText);
            }
            else
                if (Data.playerLives == 0)
            {
                GameManager.LoadGameOver();
                GameManager.WinOrLose(Data.loseText);
            }
        }
        if (Data.playerLives == 0)
        {
            GameManager.LoadGameOver();
            GameManager.WinOrLose(Data.loseText);
        }
    }
}
