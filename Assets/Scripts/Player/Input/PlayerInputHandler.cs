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
    
    [SerializeField]
    private InventoryObject inventory;
    


    public void OnMoveInput(InputAction.CallbackContext context)
    {
        _movementInput = context.ReadValue<Vector2>();
    }
    private void FixedUpdate()
    {
        // TODO Make this update just the transform.
        rb.velocity = new Vector2(_movementInput.x * moveSpeed, _movementInput.y * moveSpeed);
    }

    private void Update()
    {

        // if (_timer >= damageInc)
        // {
        //     _timer = 0f;
        //     health -= 1 * _enemyList.Count;
        //     Debug.Log("Health Now: " + health);
        // }
        
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        var item = col.GetComponent<Item>();
        if (item)
        {
            Debug.Log("ADDED VIAL");
            inventory.AddItem(item.item, 1);
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        // _started = false;
        // var enemyId = col.GetInstanceID();
        // _enemyList.Remove(enemyId);
    }
    
    
}