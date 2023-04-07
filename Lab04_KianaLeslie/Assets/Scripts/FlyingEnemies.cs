using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FlyingEnemies : MonoBehaviour
{
    float timer = 0;
    float movementTimer = 0.5f;
    int movementCount = 0;
    float speed = 0.25f;
    public int lives = 3;
    [SerializeField] private TextMeshProUGUI livesText;
    Vector3 respawn = new Vector3(-4.91f, -2.28f, 0f);
    void Start()
    {
        lives = 3;
    }
    void Update()
    {
        if (movementCount == 5)
        {
            transform.Translate(new Vector3(0, 0f, 0));
            movementCount = -1;
            speed = -speed;
            timer = 0;
        }
        timer += Time.deltaTime;
        if (timer > movementTimer && movementCount < 5)
        {
            transform.Translate(new Vector3(speed, 0, 0));
            timer = 0;
            movementCount++;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            lives--;
            livesText.text = "Lives: " + lives;
            if (lives == 0)
            {
                GameSceneManager.LoadGameOver();
            }
            collision.gameObject.transform.position = respawn;
        }
    }
}