using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject player;
    private Rigidbody2D rb;
    private Animator animate;
    private SpriteRenderer sprite;
    private BoxCollider2D collider;

    private float directionX;
    [SerializeField] private float speed = 7f;
    [SerializeField] private float jump = 14f;
    [SerializeField] private LayerMask ground;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animate = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        collider = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) && player.transform.position.x <= 100f)
        {
            transform.Translate(new Vector3(7 * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) && player.transform.position.x >= -18.63f)
        {
            transform.Translate(new Vector3(-7 * Time.deltaTime, 0, 0));
        }

        directionX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(directionX * speed, rb.velocity.y);
        if (Input.GetButtonDown("Jump") && IsTouchingGround())
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
    private bool IsTouchingGround()
    {
        //finds box around player, moves the box down slightly bc the upper box checks for overlap
        return Physics2D.BoxCast(collider.bounds.center, collider.bounds.size, 0f, Vector2.down, .1f, ground);
    }
}