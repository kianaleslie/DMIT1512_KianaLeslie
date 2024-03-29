using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] PaddleBehaviour leftPaddle;
    [SerializeField] PaddleBehaviour rightPaddle;
    [SerializeField] PlungerBehaviour plunger;


    [SerializeField] InputAction useLeft;
    [SerializeField] InputAction useRight;
    [SerializeField] InputAction pullPlunger;

    private void OnEnable()
    {
        useLeft.Enable();
        useRight.Enable();
        pullPlunger.Enable();
    }
    private void OnDisable()
    {
        useLeft.Disable();
        useRight.Disable();
        pullPlunger.Disable();
    }
    void Start()
    {
        OnEnable();
    }
    void Update()
    {
        leftPaddle.Flip(useLeft.IsPressed());
        rightPaddle.Flip(useRight.IsPressed());
        plunger.Pull(pullPlunger.ReadValue<float>());
    }
}