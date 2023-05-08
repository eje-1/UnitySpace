using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBulletController : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefab of the bullet to be spawned
    public float speed = 10f; // Bullet speed
    public float lifetime = 1f; // Time until bullet is destroyed
    public float shootDelay = 1f; // Delay between shots

    private int numEnemies;

    private void Start()
    {
        // Find all enemies in the scene
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        numEnemies = enemies.Length;

        // Start shooting
        InvokeRepeating("ShootBullet", shootDelay, shootDelay);
    }

    private void ShootBullet()
    {
        if (numEnemies > 0)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            Rigidbody2D rb2d = bullet.GetComponent<Rigidbody2D>();
            rb2d.velocity = transform.right * speed; // Shoot bullet to the right
            Destroy(bullet, lifetime); // Destroy bullet after lifetime seconds
        }
    }

    public void DecreaseEnemyCount()
    {
        numEnemies--;
    }

}

