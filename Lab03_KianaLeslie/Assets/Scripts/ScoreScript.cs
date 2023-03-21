using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Text = TMPro.TMP_Text;

public class ScoreScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision was with a scoring object
        if (collision.gameObject.CompareTag("ScoringObject"))
        {
            // Add points to the score
            score += 10;
            UpdateScoreText();
        }
    }

    private void UpdateScoreText()
    {
        // Update the score text element with the current score value
        scoreText.text = "Score: " + score.ToString();
    }
    private void Update()
    {
        UpdateScoreText();
    }
}