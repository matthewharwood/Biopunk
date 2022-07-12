using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemExperience : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.name == "Hero")
        {
            Debug.Log("EXPERIENCE");
            Destroy(gameObject);
        }
    }
}
