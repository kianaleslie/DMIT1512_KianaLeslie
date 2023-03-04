using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Text = TMPro.TMP_Text;

public class UITextScript : MonoBehaviour
{
    [SerializeField] public static GameObject[] invaders;

    [SerializeField] TMP_Text playerText;
    public TextMeshProUGUI invaderText;
    void Update()
    {
        invaders = GameObject.FindGameObjectsWithTag("Invaders");
        invaderText.text = "Enemies: " + invaders.Length.ToString();
        playerText.text = "Lives: " + Data.playerLives.ToString();
        if (Data.playerLives == 0)
        {
            GameManager.LoadGameOver();
            GameManager.WinOrLose(Data.loseText);
        }
        if (invaders.Length == 0)
        {
            if (Data.playerLives > 0)
            {
                GameManager.LoadLevelTwo();
            }
            else
                if (Data.playerLives == 0)
            {
                GameManager.LoadGameOver();
                GameManager.WinOrLose(Data.loseText);
            }
        }
    }
}