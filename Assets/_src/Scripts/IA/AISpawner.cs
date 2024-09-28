using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawner : MonoBehaviour
{
    public EnemyScritptable[] EnemiesBrains;
    public GameObject EnemyPrefab;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 0, 1);
    }

    public void SpawnEnemy()
    {
        var enemy = Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
        enemy.GetComponent<AIControler>().Init(EnemiesBrains[Random.Range(0, EnemiesBrains.Length)]);
    }
}
