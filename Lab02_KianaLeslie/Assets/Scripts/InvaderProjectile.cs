using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderProjectile : MonoBehaviour
{
    Vector3 respawnPlayer = new Vector3(8, -4, 0);
    [SerializeField] GameObject invaderProjectile;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -3 * Time.deltaTime, 0));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerShip")
        {
            collision.gameObject.transform.position = respawnPlayer;
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
}