using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Projectile : MonoBehaviour
{
    [SerializeField] GameObject playerProjectile;
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
        if (collision.gameObject.tag == "Invaders")
        {
            Destroy(collision.gameObject);
            Destroy(playerProjectile);
            GameManager.playGame = true;
        }
        if (collision.gameObject.tag == "Finish")
        {
            Destroy (playerProjectile); 
        }
    }
}
