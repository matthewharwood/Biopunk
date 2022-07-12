using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    
    [SerializeField]
    private float speed = 1;

    
    [SerializeField]
    private EnemyObject enemyObject;
    
    private void Update()
    {
        var step =  speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name);
        if (col.gameObject.name == "Hero")
        {
            
            var position = gameObject.transform.position;
            var money = enemyObject.MaybeDropMoney();
            var xp = enemyObject.MaybeDropExperience();
            if (money)
            {
                Instantiate(money.prefab, new Vector3(position.x, position.y, 0), Quaternion.identity);    
            }

            if (xp)
            {
                Instantiate(xp.prefab, new Vector3(position.x, position.y, 0), Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
}
