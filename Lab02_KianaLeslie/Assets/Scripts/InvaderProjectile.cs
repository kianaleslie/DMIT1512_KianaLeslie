using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderProjectile : MonoBehaviour
{
    [SerializeField] GameObject invaderProjectile;
    void Update()
    {
        transform.Translate(new Vector3(0, -3 * Time.deltaTime, 0));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerShip")
        {
            collision.gameObject.transform.position = Respawn();
            if(Data.playerLives == 0)
            {
                GameManager.LoadGameOver();
                GameManager.WinOrLose(Data.loseText);
            }
            Data.playerLives -= 1;
            Destroy(invaderProjectile);
            GameManager.playGame = false;
        }
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(invaderProjectile);
        }
        if (collision.gameObject.tag == "Barrier")
        {
            Destroy(invaderProjectile);
        }
    }
    public Vector3 Respawn()
    {
        GameManager.playGame = false;
        Vector3 respawnPlayer = new Vector3(8, -4, 0);
        return respawnPlayer;
    }
}