using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerObject playerObject;

    private void Update()
    {
        playerObject.position = transform.position;
    }
}
