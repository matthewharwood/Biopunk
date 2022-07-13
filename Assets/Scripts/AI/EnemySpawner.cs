using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.Pool;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    public IObjectPool<Enemy> pool;
    [SerializeField] private EnemyObject enemyToSpawn;
    
    private void Awake()
    {

        pool = new ObjectPool<Enemy>(
            () =>
            {
                var e = Instantiate(enemyToSpawn.prefab);
                var script = e.GetComponent<Enemy>();
                
                script.SetPool(pool);
                script.SetPrefab(e);
                return e;
            }, shape =>
            {
                shape.gameObject.SetActive(true);
            }, shape =>
            {
                shape.gameObject.SetActive(false);
            }, shape =>
            {
                Destroy(shape.gameObject);
            });

    }

    void Start()
    {
        for (var i = 0; i < 350; i++)
        {
            var size = 15;
            var shape = pool.Get();
            var offset = new Vector3(Random.Range(-size, size), Random.Range(-size, size), 0);
            shape.transform.position = offset;    
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
