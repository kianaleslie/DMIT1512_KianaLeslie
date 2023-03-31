using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject player;
    Rigidbody2D rb;
    private float directionX = 0f;
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && player.transform.position.x <= 8f)
        {
            transform.Translate(new Vector3(7 * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.A) && player.transform.position.x >= -8f)
        {
            transform.Translate(new Vector3(-7 * Time.deltaTime, 0, 0));
        }
        directionX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(directionX * 7f, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(0, 14, 0);
        }
    }
}