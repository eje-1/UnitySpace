using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoveController : MonoBehaviour
{
    public float speed = 10f;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;
    public int score = 0; // <-- Add this line to define the score variable
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector2(horizontalInput, verticalInput) * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            Rigidbody2D bulletRb2d = bullet.GetComponent<Rigidbody2D>();
            bulletRb2d.velocity = transform.up * bulletSpeed;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject); // Destroy the enemy
            score += 10; // Increase the score by 10 when the player collides with an enemy
            scoreText.text = "Score: " + score; // Update the scoreText object to display the updated score
            Debug.Log(scoreText);
        }

    }
}