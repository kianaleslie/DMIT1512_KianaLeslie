
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int lives = 3;
    [SerializeField] private TextMeshProUGUI livesText;
    Vector3 respawn = new Vector3(-4.91f, -2.28f, 0f);
    void Start()
    {
        lives = 3;
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