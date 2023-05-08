using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private SpawnBulletController spawner;

    private void Start()
    {
        spawner = GameObject.FindObjectOfType<SpawnBulletController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject); // Destroy the bullet
            Destroy(gameObject); // Destroy this enemy

            // Decrease enemy count in SpawnBulletController
            spawner.DecreaseEnemyCount();
        }
    }
}
