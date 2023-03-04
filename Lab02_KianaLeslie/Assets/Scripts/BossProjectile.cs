using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossProjectile : MonoBehaviour
{
    [SerializeField] GameObject bossProjectile;
    void Update()
    {
        transform.Translate(new Vector3(0, -3 * Time.deltaTime, 0));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerShip")
        {
            collision.gameObject.transform.position = Respawn();
            Destroy(bossProjectile);
            GameManager.playGame = false;
        }
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(bossProjectile);
        }
        if (collision.gameObject.tag == "Barrier")
        {
            Destroy(bossProjectile);
        }
    }
    public Vector3 Respawn()
    {
        GameManager.playGame = false;
        Vector3 respawnPlayer = new Vector3(8, -4, 0);
        return respawnPlayer;
    }
}