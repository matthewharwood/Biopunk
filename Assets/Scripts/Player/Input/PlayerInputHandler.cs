using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    [SerializeField]
    private int health = 10;
    
    [SerializeField]
    private float moveSpeed = 5f;
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private Transform t;
    [SerializeField]
    private int damageInc = 1;
    
    private Vector2 _movementInput;
    
    private bool _started = false;
    private float _timer;
    

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        _movementInput = context.ReadValue<Vector2>();
        // Debug.Log(_movementInput);
        
    }
    private void FixedUpdate()
    {
        // Make this update just the transform.
        rb.velocity = new Vector2(_movementInput.x * moveSpeed, _movementInput.y * moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        _started = true;


    }

    private void Update()
    {
        if (!_started) return;
        // Debug.Log("started");
        _timer += Time.deltaTime;
        
        if (_timer >= damageInc)
        {
            _timer = 0f;
            health--;
            Debug.Log(health);    
        }
        
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        
        // Debug.Log("exit");
        _started = false;
        // Debug.Log(health);
        
    }
    
    
}