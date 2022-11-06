using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private Vector3 spawnPoint;
    private int enemyCount = 1, enemySpawnCount = 1;
    public GameObject enemy;

    private void Awake()
    {
        Instance = this;
    }


    void CreateEnemy(int count)
    {
        for (int i = 0; i < count; i++)
        {
            spawnPoint = new Vector3(Random.Range(-5, 0), 4, Random.Range(-3, 3));
            Instantiate(enemy, spawnPoint, enemy.transform.rotation);
        }
    }
    public void EnemyDestroyed()
    {
        if (enemyCount > 0)
        {
            enemyCount--;
            if (enemyCount == 0)
            {
                enemySpawnCount++;
                enemyCount = enemySpawnCount;
                CreateEnemy(enemySpawnCount);
            }
        }
    }
    
}
