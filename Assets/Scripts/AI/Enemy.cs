using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Serialization;
using static UnityEngine.Screen;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float speed = 1;

    private Enemy _phab;
    [SerializeField]
    public EnemyObject enemyObject;

    private IObjectPool<Enemy> _pool;
    public void SetPool(IObjectPool<Enemy> pool) => _pool = pool;
    public void SetPrefab(Enemy phab) => _phab = phab;
    
    private void Update()
    {
        var step =  speed * Time.deltaTime;
        var position = transform.position;
        var target = new Vector3(width / 2 / height / 2, position.z);
        position = Vector3.MoveTowards(position, target, step);
        transform.position = position;
        if (transform.position == target)
        {
            _pool.Release(_phab);
        } 
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Weapon")
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
