using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    /* [SerializeField] */
    Rigidbody2D rBody;
    PlayerInput playerInput;
    Vector2 moveVector;
    void Start()
    {
        rBody.GetComponent<Rigidbody2D>();
    }
    void Update()
    {

    }
    private void FixedUpdate()
    {
        rBody.AddForce(4.5f * moveVector * Vector2.right);
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.action.WasPerformedThisFrame())
        {
            rBody.AddForce(8f * Vector2.up, ForceMode2D.Impulse);
        }
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.action.WasPerformedThisFrame())
        {
            moveVector = context.ReadValue<Vector2>();
        }
    }
}