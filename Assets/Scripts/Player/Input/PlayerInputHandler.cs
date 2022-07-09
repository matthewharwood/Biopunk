using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    
    [SerializeField]
    private float moveSpeed = 5f;
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private Transform t;
    
    private Vector2 _movementInput;
    
    public void OnMoveInput(InputAction.CallbackContext context)
    {
        _movementInput = context.ReadValue<Vector2>();
        Debug.Log(_movementInput);
        
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(_movementInput.x * moveSpeed, _movementInput.y * moveSpeed);
    }
}