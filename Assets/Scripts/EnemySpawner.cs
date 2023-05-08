using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Enemy prefab to spawn
    public float spawnInterval = 1f; // Time interval between spawns
    public int maxEnemies = 10; // Maximum number of enemies to spawn
    public float spawnRadius = 5f; // Distance from spawner where enemies can spawn
    public float rotationAngle = 0f; // Rotation angle for spawned enemies

    private int enemyCount = 0; // Current number of enemies spawned
    private float spawnTimer = 0f; // Timer to keep track of spawn interval

    private void Update()
    {
        if (enemyCount < maxEnemies)
        {
            spawnTimer += Time.deltaTime;
            if (spawnTimer >= spawnInterval)
            {
                SpawnEnemy();
                spawnTimer = 0f;
            }
        }
    }

    private void SpawnEnemy()
    {
        Vector2 spawnPos = Random.insideUnitCircle.normalized * spawnRadius + (Vector2)transform.position;
        GameObject enemy = Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
        enemy.transform.rotation = Quaternion.Euler(0f, 0f, rotationAngle);
        enemyCount++;
    }

    public void DecreaseEnemyCount()
    {
        enemyCount--;
    }
}
