using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text lostText;
    [SerializeField] TMP_Text wonText;
    void Update()
    {
        scoreText.text = "High Score: " + Data.playerScore.ToString();
        //lostText.text = "YOU LOSE!";
        //wonText.text = "YOU WIN!";
    }
}