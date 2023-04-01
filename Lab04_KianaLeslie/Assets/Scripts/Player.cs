using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    //[SerializeField] GameObject player;
    private Rigidbody2D rb;
    private Animator animate;
    private SpriteRenderer sprite;

    private float directionX;
    [SerializeField] private float speed = 7f;
    [SerializeField] private float jump = 14f;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animate = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        //if (Input.GetKey(KeyCode.D) && player.transform.position.x <= 8f)
        //{
        //    transform.Translate(new Vector3(7 * Time.deltaTime, 0, 0));
        //}
        //if (Input.GetKey(KeyCode.A) && player.transform.position.x >= -8f)
        //{
        //    transform.Translate(new Vector3(-7 * Time.deltaTime, 0, 0));
        //}

        directionX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(directionX * speed, rb.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
        }
        UpdateAnimation();
    }
    private void UpdateAnimation()
    {
        if (directionX > 0f)
        {
            animate.SetBool("Running", true);
            sprite.flipX = false;
        }
        else
            if (directionX < 0f)
        {
            animate.SetBool("Running", true);
            sprite.flipX = true;
        }
        else
        {
            animate.SetBool("Running", false);
        }
    }
}